// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.IMG
{
    [NativeName("Name", "GLenum")]
    public enum IMG : int
    {
        [NativeName("Name", "EGL_CONTEXT_PRIORITY_LEVEL_IMG")]
        ContextPriorityLevelImg = 0x3100,
        [NativeName("Name", "EGL_CONTEXT_PRIORITY_HIGH_IMG")]
        ContextPriorityHighImg = 0x3101,
        [NativeName("Name", "EGL_CONTEXT_PRIORITY_MEDIUM_IMG")]
        ContextPriorityMediumImg = 0x3102,
        [NativeName("Name", "EGL_CONTEXT_PRIORITY_LOW_IMG")]
        ContextPriorityLowImg = 0x3103,
        [NativeName("Name", "EGL_NATIVE_BUFFER_MULTIPLANE_SEPARATE_IMG")]
        NativeBufferMultiplaneSeparateImg = 0x3105,
        [NativeName("Name", "EGL_NATIVE_BUFFER_PLANE_OFFSET_IMG")]
        NativeBufferPlaneOffsetImg = 0x3106,
    }
}
