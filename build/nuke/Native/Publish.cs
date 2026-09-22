// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Tools.Git;
using Nuke.Common.Tooling;
using Serilog;

partial class Build
{
    /// <summary>
    /// Commits freshly built native binaries back into the repository and pushes them.
    /// </summary>
    /// <remarks>
    /// The binaries are build products that are deliberately committed rather than uploaded as
    /// workflow artefacts, because the NuGet package is assembled from <c>runtimes/**</c> in the
    /// working tree. A single-purpose repository does not need the review-a-pull-request dance that
    /// the equivalent step in the Silk.NET monorepo performs, so this commits straight onto the
    /// branch CI checked out.
    /// <para>
    /// Outside CI this is a no-op: a local build writes the binaries into the working tree and
    /// leaves them for the developer to inspect or commit by hand. Set
    /// <c>SILKNET_EGL_PUBLISH=1</c> to force publishing locally.
    /// </para>
    /// </remarks>
    void PublishNativeBinaries(string name)
    {
        var inCi = GitHubActions.Instance is not null;
        var forced = Environment.GetEnvironmentVariable("SILKNET_EGL_PUBLISH") == "1";
        if (!inCi && !forced)
        {
            Log.Information
            (
                "{Name} binaries staged under native/. Not committing: not running in CI " +
                "(set SILKNET_EGL_PUBLISH=1 to publish anyway).",
                name
            );
            return;
        }

        var branch = GitTasks.GitCurrentBranch(RootDirectory);
        if (string.IsNullOrWhiteSpace(branch) || branch == "HEAD")
        {
            Log.Warning("Not on a named branch (currently '{Branch}'); skipping publish.", branch);
            return;
        }

        // -f because the native binaries are ignored by default (see .gitignore: bin/obj and
        // friends); they are intentional build outputs rather than accidental artefacts.
        GitTasks.Git("add -f native/*/runtimes/*/native/*", RootDirectory);

        var staged = GitTasks.Git("diff --cached --name-only", RootDirectory, logOutput: false);
        if (!staged.Any(x => !string.IsNullOrWhiteSpace(x.Text)))
        {
            Log.Information("No {Name} binary changes to commit.", name);
            return;
        }

        var message = $"New {name} binaries for {System.Runtime.InteropServices.RuntimeInformation.OSDescription}";
        GitTasks.Git($"commit -m \"{message}\"", RootDirectory);
        GitTasks.Git($"push origin \"{branch}\"", RootDirectory);
        Log.Information("Published {Name} binaries on branch {Branch}.", name, branch);
    }
}
