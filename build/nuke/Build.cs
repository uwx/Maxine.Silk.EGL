// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Nuke.Common;

/// <summary>
/// Build entry point. The default target (see <c>Main</c> in Build.Support.cs) is <c>Angle</c>,
/// so a bare <c>./build.sh</c> rebuilds the ANGLE native binaries for the current platform.
/// </summary>
partial class Build : NukeBuild
{
}
