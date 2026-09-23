// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.NOK
{
    [NativeName("Name", "GLenum")]
    public enum NOK : int
    {
        [NativeName("Name", "EGL_Y_INVERTED_NOK")]
        YInvertedNok = 0x307F,
    }
}
