// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.EGL
{
    /// <summary>
    /// Contains the library name of EGL.
    /// </summary>
    internal class EGLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libEGL.so.1" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "/System/Library/Frameworks/EGL.framework/EGL" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libEGL.so.1" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "/System/Library/Frameworks/EGL.framework/EGL" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "libEGL.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "libEGL.dll" };
    }
}
