// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.KHR
{
    public static class KhrStreamProducerEglsurfaceOverloads
    {
        public static unsafe nint CreateStreamProducerSurface(this KhrStreamProducerEglsurface thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateStreamProducerSurface(dpy, config, stream, in attrib_list.GetPinnableReference());
        }

    }
}

