// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.TIZEN
{
    [NativeName("Name", "GLenum")]
    public enum TIZEN : int
    {
        [Obsolete("Deprecated in favour of \"BufferTizen\"")]
        [NativeName("Name", "EGL_NATIVE_BUFFER_TIZEN")]
        NativeBufferTizen = 0x32A0,
        [Obsolete("Deprecated in favour of \"SurfaceTizen\"")]
        [NativeName("Name", "EGL_NATIVE_SURFACE_TIZEN")]
        NativeSurfaceTizen = 0x32A1,
        [NativeName("Name", "EGL_NATIVE_BUFFER_TIZEN")]
        BufferTizen = 0x32A0,
        [NativeName("Name", "EGL_NATIVE_SURFACE_TIZEN")]
        SurfaceTizen = 0x32A1,
    }
}
