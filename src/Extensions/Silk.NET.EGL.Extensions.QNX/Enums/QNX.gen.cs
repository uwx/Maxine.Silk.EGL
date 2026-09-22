// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.QNX
{
    [NativeName("Name", "GLenum")]
    public enum QNX : int
    {
        [NativeName("Name", "EGL_NATIVE_BUFFER_QNX")]
        NativeBufferQnx = 0x3551,
        [NativeName("Name", "EGL_PLATFORM_SCREEN_QNX")]
        PlatformScreenQnx = 0x3550,
    }
}
