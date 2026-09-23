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
    public static class KhrPartialUpdateOverloads
    {
        public static unsafe bool SetDamageRegion(this KhrPartialUpdate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> rects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n_rects)
        {
            // SpanOverloader
            return thisApi.SetDamageRegion(dpy, surface, out rects.GetPinnableReference(), n_rects);
        }

    }
}

