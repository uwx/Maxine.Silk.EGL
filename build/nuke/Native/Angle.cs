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
    /// Each platform builds only the architectures it can: Windows produces x64, x86 or arm64,
    /// Linux produces x64 or a cross-compiled arm64, and macOS builds both architectures and merges
    /// them into a single universal binary with <c>lipo</c>. With no architecture named, Windows
    /// builds every one its host supports; naming one with <c>SILKNET_EGL_TARGET_CPU</c> builds just
    /// that one, which is what CI does so each architecture can have a runner of its own. ANGLE is
    /// fetched fresh from googlesource rather than read from a submodule, so no checkout of it is
    /// required.
    /// </remarks>
    Target Angle => _ => _
        .Executes
        (
            () =>
            {
                // What we are building *for*, which is not always what we are building *on*: the
                // Linux arm64 job cross-compiles from an x64 runner (see the workflow), and no amount
                // of looking at the host will reveal that.
                var targetCpu = Environment.GetEnvironmentVariable("SILKNET_EGL_TARGET_CPU");

                var tempDir = (AbsolutePath) Directory.CreateTempSubdirectory("silkDotNetAngleBuild").FullName;
                var depotTools = tempDir / "depot_tools";
                InheritedShell($"git clone --depth 1 --single-branch https://chromium.googlesource.com/chromium/tools/depot_tools.git", tempDir).AssertZeroExitCode();
                AddToPath(depotTools);

                // A freshly cloned depot_tools cannot run its own tools yet -- the interpreter is
                // downloaded on first use -- so bootstrap it here, before anything tries to use it.
                //
                // On Linux and macOS this step is load-bearing twice over. The `fetch` *shell*
                // wrapper execs `python-bin/python3`, which exits immediately unless
                // `python3_bin_reldir.txt` exists, and that file is written by this bootstrap. Unlike
                // `fetch.bat` it does not call the updater first, so without this `fetch` dies before
                // it starts with "python3_bin_reldir.txt not found. need to initialize depot_tools by
                // running gclient, update_depot_tools or ensure_bootstrap." `ensure_bootstrap` is the
                // documented way to initialise an existing checkout, and unlike `update_depot_tools`
                // it syncs the checkout as it stands instead of moving it out from under us.
                if (!OperatingSystem.IsWindows())
                {
                    InheritedShell("bash ensure_bootstrap", depotTools).AssertZeroExitCode();
                }

                // On Windows `fetch.bat` calls `update_depot_tools.bat` itself, which does install
                // Python and the CIPD tools -- but not gsutil, and gsutil is the one bootstrap that
                // cannot be left to `fetch`.
                //
                // `fetch` syncs the dependency tree in parallel, and gsutil is fetched on demand the
                // first time a sync needs it: into a directory shared by every worker, under a lock
                // whose timeout is 30 seconds. The download and its vpython setup take longer than
                // that, so the workers that lose the race to the lock give up with "Error locking
                // .../gsutil_5.35 (err: Failed to lock handle (error code: 6).)" and take the whole
                // sync down with them. That is how this used to fail on Windows, ten minutes in,
                // well past the point where it looked like it was getting somewhere. (The code
                // reported is 6 rather than a clue, because lockfile.py's win32 `_open_file` does
                // not check whether its CreateFileW succeeded -- it hands the invalid handle on, and
                // LockFileEx answers ERROR_INVALID_HANDLE.) Doing it here, with nothing else running,
                // means it is downloaded exactly once and every later worker just finds it.
                else
                {
                    // The updater also fast-forwards depot_tools to origin/main; run it before
                    // DEPOT_TOOLS_UPDATE is cleared below, so the clone is a known commit rather
                    // than whatever `fetch.bat` would have picked up partway through the build.
                    InheritedShell("update_depot_tools.bat", depotTools).AssertZeroExitCode();

                    // `python3.bat` and `gsutil.py` are the supported entry points, and going through
                    // python3.bat is what makes the bootstrapped interpreter's bin directory
                    // available -- gsutil needs python3 on PATH to unpack and run itself.
                    InheritedShell("python3.bat gsutil.py -- version", depotTools).AssertZeroExitCode();
                }

                // Now that the checkout is bootstrapped, stop depot_tools from updating itself out
                // from under the build: `fetch.bat` re-runs the updater, which fast-forwards
                // depot_tools to origin/main before every fetch.
                Environment.SetEnvironmentVariable("DEPOT_TOOLS_UPDATE", "0");

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

                if (OperatingSystem.IsLinux() && targetCpu == "arm64")
                {
                    // Chromium builds Linux against a pinned Debian bullseye sysroot rather than the
                    // host's glibc, so that the binaries run on distributions older than the one
                    // that built them. gn gen asserts that the sysroot is present and names this
                    // exact command to fetch it:
                    //   Missing sysroot (//build/linux/debian_bullseye_arm64-sysroot).
                    //   To fix, run: build/linux/sysroot_scripts/install-sysroot.py --arch=arm64
                    // This has to be done by hand rather than by `gclient sync`, because ANGLE's
                    // DEPS fetches only the x86 and x64 sysroots -- it is why the assertion is
                    // reached rather than the sysroot simply being there. Chromium cross-compiles
                    // arm64 on x64 for itself, so the sysroot exists and installs on any host; ANGLE
                    // just has no Linux arm64 builder of its own to need it. The x64 job does not
                    // need this, because install-build-deps.sh installs the amd64 sysroot there.
                    // Fetching it rather than setting use_sysroot = false is deliberate: the sysroot
                    // is what keeps the shipped libraries loadable on older glibc, and dropping it to
                    // save a download would trade that away.
                    InheritedShell("build/linux/sysroot_scripts/install-sysroot.py --arch=arm64", angleSourceDir).AssertZeroExitCode();
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
                    //
                    // One architecture per invocation when CI names one, because CI gives each
                    // architecture its own runner. gn takes only one target_cpu at a time, so
                    // building both in a single job means running gn gen and ninja twice in
                    // sequence on the same cores; on separate runners they run at the same time
                    // instead. That is worth more than the second `fetch` it costs, because the
                    // dependency sync is the part that does not parallelise -- only the compile
                    // does.
                    //
                    // With no target named, build everything the host can, which is what a local run
                    // wants. x86 is only ever attempted on an x64 host: it is a cross-build, and the
                    // arm64 runners have no x86 toolchain at all.
                    var targets = targetCpu switch
                    {
                        "x64" => new[] { ("x64", "win-x64") },
                        "x86" => new[] { ("x86", "win-x86") },
                        "arm64" => new[] { ("arm64", "win-arm64") },
                        _ => System.Runtime.InteropServices.RuntimeInformation.OSArchitecture
                            == System.Runtime.InteropServices.Architecture.Arm64
                            ? new[] { ("arm64", "win-arm64") }
                            : new[] { ("x64", "win-x64"), ("x86", "win-x86") }
                    };

                    foreach (var (cpu, rid) in targets)
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
                    // Native unless SILKNET_EGL_TARGET_CPU says otherwise, which is how the arm64
                    // job cross-compiles from the x64 runner. There is no arm64 runner that can
                    // build this at all, so a native arm64 -- what this used to assume -- cannot
                    // happen.
                    var (cpu, rid) = targetCpu == "arm64"
                        ? ("arm64", "linux-arm64")
                        : ("x64", "linux-x64");

                    GnGen
                    (
                        $"Release_{cpu}",
                        "is_debug = false",
                        "is_component_build = false",
                        "target_cpu = \"" + cpu + "\"",
                        // Pinned rather than left to default to host_os, so that it is clear the
                        // cross build is still targeting Linux.
                        "target_os = \"linux\"",
                        "angle_build_tests = false",
                        // dawn was deleted above, and wgpu defaults to on under clang with x11.
                        // Worth keeping off for arm64 in particular: this is a configuration ANGLE
                        // does not build for itself, so the fewer of its dependencies exercised the
                        // better.
                        "angle_enable_wgpu = false"
                    );
                    CopyAll
                    (
                        (angleSourceDir / "out" / $"Release_{cpu}").GlobFiles("libGLESv2.so", "libEGL.so", "libANGLE.so"),
                        runtimes / rid / "native"
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
