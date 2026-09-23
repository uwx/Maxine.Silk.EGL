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

namespace Maxine.EGL.Extensions.ANGLE
{
    public static class AngleSyncControlRateOverloads
    {
        public static unsafe bool GetMscRate(this AngleSyncControlRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(dpy, surface, numerator, out denominator.GetPinnableReference());
        }

        public static unsafe bool GetMscRate(this AngleSyncControlRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(dpy, surface, out numerator.GetPinnableReference(), denominator);
        }

        public static unsafe bool GetMscRate(this AngleSyncControlRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(dpy, surface, out numerator.GetPinnableReference(), out denominator.GetPinnableReference());
        }

    }
}

