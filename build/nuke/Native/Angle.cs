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

                var runtimes = RootDirectory / "native" / "Maxine.Silk.OpenGLES.ANGLE.Native" / "runtimes";

                if (OperatingSystem.IsWindows())
                {
                    RetargetWindowsSdk(angleSourceDir / "build" / "toolchain" / "win" / "setup_toolchain.py");
                }

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
    /// Points the vendored Chromium toolchain script at the newest installed Windows SDK.
    /// </summary>
    /// <remarks>
    /// ANGLE vendors Chromium's <c>build/</c> directory at the <c>chromium_revision</c> named in
    /// its DEPS, and <c>build/toolchain/win/setup_toolchain.py</c> hardcodes the SDK to build
    /// against: <c>SDK_VERSION = '10.0.28000.0'</c>. No GitHub runner has that version --
    /// windows-2022, windows-2025 and both of the VS2026 preview images all stop at 10.0.26100.0
    /// -- and the script hands it to vcvarsall.bat and then requires every INCLUDE path that comes
    /// back to exist. So <c>gn gen</c> fails on a path that looks doubled,
    /// "10\\include\10.0.28000.0\\um", which is really just this constant being unsatisfiable. It
    /// builds on a machine that happens to have a preview SDK of that version, which is presumably
    /// how the constant was written, and fails everywhere else -- so it only ever shows up in CI.
    ///
    /// The patch swaps the constant for a lookup of the newest SDK actually present. The pin is
    /// there to stop Chromium picking up an untested SDK by accident, which is not a risk for a
    /// build that has no other option, and a lookup keeps working whichever SDK an image ships.
    /// </remarks>
    static void RetargetWindowsSdk(AbsolutePath script)
    {
        const string pinned = "SDK_VERSION = '10.0.28000.0'";
        const string lookup = @"def _NewestInstalledSdk(default):
    # The version this script ships with is newer than any released Windows SDK, so build against
    # the newest one the machine actually has instead. Chromium pins it to avoid picking up an
    # untested SDK by accident; that is not a risk for a build that has no choice.
    kits = os.path.join(
        os.environ.get('ProgramFiles(x86)') or r'C:\Program Files (x86)',
        'Windows Kits',
        '10',
        'Include',
    )
    try:
        found = [d for d in os.listdir(kits) if re.match(r'^\d+(\.\d+)+$', d)]
    except OSError:
        return default
    return max(found, key=lambda v: [int(p) for p in v.split('.')]) if found else default


SDK_VERSION = _NewestInstalledSdk('10.0.28000.0')";

        var source = File.ReadAllText(script);
        if (!source.Contains(pinned))
        {
            throw new InvalidOperationException
            (
                $"{script} no longer pins the Windows SDK version '{pinned}'. ANGLE's "
                + "chromium_revision has probably moved; check what it pins now, and whether this "
                + "workaround is still needed at all, before dropping it."
            );
        }

        File.WriteAllText(script, source.Replace(pinned, lookup));
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
