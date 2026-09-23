// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;

partial class Build
{
    /// <summary>
    /// Builds ANGLE (libEGL + libGLESv2) for the current platform and stages the results under
    /// <c>native/Maxine.Silk.OpenGLES.ANGLE.Native/runtimes/</c>.
    /// </summary>
    /// <remarks>
    /// Each platform builds only the architectures it can: Windows produces x64 and x86 in separate
    /// GN output directories, Linux produces x64, and macOS builds both architectures and merges
    /// them into a single universal binary with <c>lipo</c>. ANGLE is fetched fresh from
    /// googlesource rather than read from a submodule, so no checkout of it is required.
    /// </remarks>
    Target Angle => _ => _
        .Executes
        (
            () =>
            {
                var tempDir = (AbsolutePath) Directory.CreateTempSubdirectory("silkDotNetAngleBuild").FullName;
                InheritedShell($"git clone --depth 1 --single-branch https://chromium.googlesource.com/chromium/tools/depot_tools.git", tempDir).AssertZeroExitCode();
                AddToPath(tempDir / "depot_tools");

                if (OperatingSystem.IsWindows())
                {
                    // Use the Visual Studio installed on the machine rather than Chromium's own toolchain.
                    Environment.SetEnvironmentVariable("DEPOT_TOOLS_WIN_TOOLCHAIN", "0");

                    // ANGLE's dependency tree contains paths well past MAX_PATH -- dawn alone nests
                    // directx-shader-compiler several levels down, and its clang test data goes
                    // deeper still. Without this, `fetch` dies partway through with "Filename too
                    // long" and leaves a half-populated source tree that fails much later with a
                    // confusing GN error. The GIT_CONFIG_* variables are read by git itself and
                    // inherited by every git process it spawns, so gclient's nested checkouts are
                    // covered without touching the machine's global git configuration.
                    Environment.SetEnvironmentVariable("GIT_CONFIG_COUNT", "1");
                    Environment.SetEnvironmentVariable("GIT_CONFIG_KEY_0", "core.longpaths");
                    Environment.SetEnvironmentVariable("GIT_CONFIG_VALUE_0", "true");
                }

                var angleSourceDir = tempDir / "angle_source";
                EnsureCleanDirectory(angleSourceDir);
                InheritedShell("fetch --no-history angle", angleSourceDir).AssertZeroExitCode();

                // fetch is a thin wrapper around gclient, which syncs the dependency tree in the
                // background. On Windows the tree cannot be pruned while those children are still
                // running, so wait for them to settle before touching anything under third_party.
                WaitForGitToSettle();

                // save space
                // DeleteDirectory takes too long (it deletes individual files)
                ClearTree(angleSourceDir / "third_party" / "VK-GL-CTS"); // this is only possible because we disable tests below
                ClearTree(angleSourceDir / "third_party" / "dawn"); // this is only possible because we disable wgpu below
                (angleSourceDir / "third_party").GlobDirectories("*.git").ForEach(ClearTree);

                if (OperatingSystem.IsLinux())
                {
                    // --no-prompt: the script otherwise waits for input on a TTY that CI doesn't have.
                    InheritedShell("sudo ./build/install-build-deps.sh --no-prompt", angleSourceDir).AssertZeroExitCode();
                }

                var runtimes = RootDirectory / "native" / "Maxine.Silk.OpenGLES.ANGLE.Native" / "runtimes";

                void GnGen(string outName, params string[] args)
                {
                    var @out = angleSourceDir / "out" / outName;
                    EnsureCleanDirectory(@out);

                    // Write args.gn rather than passing --args. InheritedShell hands the command to a
                    // shell, and the quoting --args requires (its value itself contains double quotes)
                    // does not survive that intact on every platform. GN reads args.gn from the build
                    // directory by itself, so this sidesteps the problem.
                    File.WriteAllText(@out / "args.gn", string.Join(Environment.NewLine, args));

                    InheritedShell($"gn gen \"{@out}\"", angleSourceDir).AssertZeroExitCode();
                    InheritedShell($"autoninja -C \"{@out}\"", angleSourceDir).AssertZeroExitCode();
                }

                if (OperatingSystem.IsWindows())
                {
                    // gn only takes one target_cpu at a time, so each architecture needs its own
                    // build directory and its own copy step.
                    //
                    // is_component_build = false is what makes this work: with it on, ANGLE splits
                    // into libEGL/libGLESv2/libANGLE DLLs that depend on each other and on a pile of
                    // Chromium runtime DLLs that are not shipped, so nothing loads. Turning it off
                    // produces self-contained libraries.
                    foreach (var (cpu, rid) in new[]
                    {
                        ("x64", "win-x64"),
                        ("x86", "win-x86"),
                    })
                    {
                        GnGen
                        (
                            $"Release_{cpu}",
                            "is_debug = false",
                            "is_component_build = false",
                            "target_cpu = \"" + cpu + "\"",
                            "angle_build_tests = false",
                            // dawn was deleted above, and wgpu defaults to on under clang.
                            "angle_enable_wgpu = false"
                        );
                        CopyAll
                        (
                            // libANGLE might not exist, this is fine
                            (angleSourceDir / "out" / $"Release_{cpu}").GlobFiles("libGLESv2.dll", "libEGL.dll", "libANGLE.dll"),
                            runtimes / rid / "native"
                        );
                    }
                }
                else if (OperatingSystem.IsLinux())
                {
                    GnGen
                    (
                        "Release_x64",
                        "is_debug = false",
                        "is_component_build = false",
                        "target_cpu = \"x64\"",
                        "angle_build_tests = false",
                        // dawn was deleted above, and wgpu defaults to on under clang with x11.
                        "angle_enable_wgpu = false"
                    );
                    CopyAll
                    (
                        (angleSourceDir / "out" / "Release_x64").GlobFiles("libGLESv2.so", "libEGL.so", "libANGLE.so"),
                        runtimes / "linux-x64" / "native"
                    );
                }
                else if (OperatingSystem.IsMacOS())
                {
                    foreach (var arch in new[] { "arm64", "x64" })
                    {
                        GnGen
                        (
                            $"Release_{arch}",
                            $"target_cpu = \"{arch}\"",
                            "is_debug = false",
                            "angle_build_tests = false",
                            "angle_enable_null = false",
                            "angle_enable_vulkan = false",
                            // dawn was deleted above, and wgpu defaults to on.
                            "angle_enable_wgpu = false",
                            "angle_enable_gl = false"
                        );
                    }

                    // create universal mac binaries
                    var universalNativeRuntimes = runtimes / "osx" / "native";
                    EnsureCleanDirectory(universalNativeRuntimes);
                    foreach (var lib in new[] { "libGLESv2.dylib", "libEGL.dylib" })
                    {
                        var x64Lib = angleSourceDir / "out" / "Release_x64" / lib;
                        var arm64Lib = angleSourceDir / "out" / "Release_arm64" / lib;
                        InheritedShell
                            (
                                $"lipo -create \"{arm64Lib}\" \"{x64Lib}\" -output \"{universalNativeRuntimes / lib}\"",
                                angleSourceDir
                            )
                            .AssertZeroExitCode();
                    }
                }

                PublishNativeBinaries("ANGLE");
            }
        );

    /// <summary>
    /// Deletes a directory, clearing the read-only flag first.
    /// </summary>
    /// <remarks>
    /// Git marks the files it writes into <c>.git/objects</c> read-only, and Windows refuses to
    /// unlink a read-only file, surfacing it as <see cref="UnauthorizedAccessException"/>. The
    /// dependency trees pruned below are entire git checkouts, so a plain recursive delete
    /// reliably fails partway through with "Access to the path 'pack-*.idx' is denied".
    /// </remarks>
    static void ClearTree(AbsolutePath path)
    {
        if (!Directory.Exists(path))
        {
            return;
        }

        foreach (var file in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
        {
            var attributes = File.GetAttributes(file);
            if ((attributes & FileAttributes.ReadOnly) != 0)
            {
                File.SetAttributes(file, attributes & ~FileAttributes.ReadOnly);
            }
        }

        Directory.Delete(path, true);
    }

    /// <summary>
    /// Waits for git processes spawned by <c>fetch</c> to exit.
    /// </summary>
    /// <remarks>
    /// On Windows an open handle keeps a file locked, so pruning the tree while git is still
    /// running under it fails or silently leaves entries behind. Everywhere else this is a no-op:
    /// the children have already exited by the time the shell that started them returns.
    /// </remarks>
    static void WaitForGitToSettle()
    {
        if (!OperatingSystem.IsWindows())
        {
            return;
        }

        for (var attempt = 0; attempt < 60; attempt++)
        {
            var running = System.Diagnostics.Process.GetProcessesByName("git")
                .Where(x =>
                {
                    try
                    {
                        return !x.HasExited;
                    }
                    catch (InvalidOperationException)
                    {
                        return false;
                    }
                })
                .Any();

            if (!running)
            {
                return;
            }

            System.Threading.Thread.Sleep(1000);
        }
    }
}
