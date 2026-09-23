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

        // Every leg of the build matrix reaches this point at roughly the same moment -- they start
        // together and spend about the same time compiling -- and each pushes its own commit onto
        // the same branch. Whoever pushes second is rejected as non-fast-forward, which fails a job
        // whose actual build succeeded. So the push is the one step here that has to expect the
        // branch to have moved underneath it: rebase onto whatever landed and try again.
        //
        // The retries have to stay patient enough to cover the spread between the first leg to
        // finish and the last, which is minutes rather than seconds -- they build different amounts
        // of code, and a leg that lost a race once usually has another leg still to land behind it.
        // Each round is therefore: wait, fetch, rebase, push again.
        const int attempts = 12;
        for (var attempt = 1; ; attempt++)
        {
            try
            {
                GitTasks.Git($"push origin \"{branch}\"", RootDirectory);
                break;
            }
            catch (ProcessException) when (attempt < attempts)
            {
                // Capped rather than proportional, so the wait can never grow into the tens of
                // minutes: what is being waited out is other jobs finishing, not rate limiting.
                var backoff = Math.Min(5 * attempt, 30);
                Log.Warning
                (
                    "Push to {Branch} was rejected (attempt {Attempt} of {Attempts}); rebasing onto " +
                    "origin/{Branch} in {Backoff}s and retrying.",
                    branch, attempt, attempts, branch, backoff
                );

                // The legs build different RIDs, so their commits touch disjoint files and the
                // rebase applies without conflict. The pause is to let the leg that won the race
                // finish landing before fetching, rather than racing it a second time.
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(backoff));
                GitTasks.Git($"fetch origin \"{branch}\"", RootDirectory);
                GitTasks.Git($"rebase \"origin/{branch}\"", RootDirectory);
            }
        }

        Log.Information("Published {Name} binaries on branch {Branch}.", name, branch);
    }
}
