// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Maxine.EGL
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
        /// <remarks>
        /// Android ships EGL unversioned -- <c>libEGL.so.1</c> is the Linux soname, and it does not
        /// exist on Android, so listing it here meant <c>EGL.GetApi()</c> could not load anything
        /// there. (There is no need to bundle an EGL either: Android's own libEGL.so is AOSP's
        /// dispatcher onto the vendor's GLES driver, which every device with GLES has.)
        /// </remarks>
        public override string[] Android => new[] { "libEGL.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "/System/Library/Frameworks/EGL.framework/EGL" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "libEGL.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "libEGL.dll" };
    }
}
