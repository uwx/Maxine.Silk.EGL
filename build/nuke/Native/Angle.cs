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
    /// <c>native/Silk.NET.OpenGLES.ANGLE.Native/runtimes/</c>.
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
                }

                var angleSourceDir = tempDir / "angle_source";
                EnsureCleanDirectory(angleSourceDir);
                InheritedShell("fetch --no-history angle", angleSourceDir).AssertZeroExitCode();

                // save space
                // DeleteDirectory takes too long (it deletes individual files)
                Directory.Delete(angleSourceDir / "third_party" / "VK-GL-CTS", true); // this is only possible because we disable tests below
                Directory.Delete(angleSourceDir / "third_party" / "dawn", true); // this is only possible because we disable wgpu below
                (angleSourceDir / "third_party").GlobDirectories("*.git").ForEach(DeleteDirectory);

                if (OperatingSystem.IsLinux())
                {
                    // --no-prompt: the script otherwise waits for input on a TTY that CI doesn't have.
                    InheritedShell("sudo ./build/install-build-deps.sh --no-prompt", angleSourceDir).AssertZeroExitCode();
                }

                var runtimes = RootDirectory / "native" / "Silk.NET.OpenGLES.ANGLE.Native" / "runtimes";

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
}
