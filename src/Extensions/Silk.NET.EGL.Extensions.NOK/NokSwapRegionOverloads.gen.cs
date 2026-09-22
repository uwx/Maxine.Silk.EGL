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

namespace Silk.NET.EGL.Extensions.NOK
{
    public static class NokSwapRegionOverloads
    {
        public static unsafe bool SwapBuffersRegionNok(this NokSwapRegion thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> rects)
        {
            // SpanOverloader
            return thisApi.SwapBuffersRegionNok(dpy, surface, numRects, in rects.GetPinnableReference());
        }

    }
}

