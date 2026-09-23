// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.WL
{
    [NativeName("Name", "GLenum")]
    public enum WL : int
    {
        [NativeName("Name", "EGL_WAYLAND_BUFFER_WL")]
        WaylandBufferWL = 0x31D5,
        [NativeName("Name", "EGL_WAYLAND_PLANE_WL")]
        WaylandPlaneWL = 0x31D6,
        [NativeName("Name", "EGL_TEXTURE_Y_U_V_WL")]
        TextureYUVWL = 0x31D7,
        [NativeName("Name", "EGL_TEXTURE_Y_XUXV_WL")]
        TextureYXuxvWL = 0x31D9,
        [NativeName("Name", "EGL_TEXTURE_EXTERNAL_WL")]
        TextureExternalWL = 0x31DA,
        [NativeName("Name", "EGL_WAYLAND_Y_INVERTED_WL")]
        WaylandYInvertedWL = 0x31DB,
    }
}
