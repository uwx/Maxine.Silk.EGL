// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tooling.ProcessTasks;

partial class Build
{
    public static int Main() => Execute<Build>(x => x.Angle);

    /// <summary>
    /// Runs a command through the platform shell, inheriting this process's environment.
    /// </summary>
    /// <remarks>
    /// Used rather than <c>Nuke.Common.Tools</c> wrappers because this build drives Chromium's
    /// depot_tools (<c>fetch</c>, <c>gn</c>, <c>autoninja</c>) and <c>lipo</c>, which have no NUKE
    /// task definitions. The command line is handed to the shell verbatim, so callers that need
    /// argument quoting should prefer writing a file the tool reads by itself.
    /// </remarks>
    IProcess InheritedShell(string cmd, string workDir = null, IReadOnlyDictionary<string, string> envVars = null)
        => OperatingSystem.IsWindows()
            ? StartProcess("powershell", $"-Command {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary(envVars))
            : StartProcess("bash", $"-c {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary(envVars));

    Dictionary<string, string> CreateEnvVarDictionary(IReadOnlyDictionary<string, string> concat = null)
        => Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .Concat((concat ?? Enumerable.Empty<KeyValuePair<string, string>>())
                .Select(x => new DictionaryEntry(x.Key, x.Value)))
            .ToDictionary(x => (string) x.Key, x => (string) x.Value);

    /// <summary>
    /// Prepends <paramref name="dir"/> to this process's PATH so subsequently started child
    /// processes can find the tools in it.
    /// </summary>
    void AddToPath(string dir)
    {
        var pathVar = Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .First(x => ((string) x.Key).Equals("PATH", StringComparison.OrdinalIgnoreCase));
        Environment.SetEnvironmentVariable
        (
            (string) pathVar.Key,
            (string) pathVar.Value + (OperatingSystem.IsWindows() ? $";{dir}" : $":{dir}")
        );
    }

    static void CopyAll(IEnumerable<AbsolutePath> paths, AbsolutePath dir)
    {
        foreach (var path in paths)
        {
            CopyFile(path, dir / Path.GetFileName(path), FileExistsPolicy.Overwrite);
        }
    }
}
