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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public static class AndroidGetFrameTimestampsOverloads
    {
        public static unsafe bool GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, names, out values.GetPinnableReference());
        }

        public static unsafe bool GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, in names.GetPinnableReference(), values);
        }

        public static unsafe bool GetCompositorTiming(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetCompositorTiming(dpy, surface, numTimestamps, in names.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe bool GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, timestamps, out values.GetPinnableReference());
        }

        public static unsafe bool GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, in timestamps.GetPinnableReference(), values);
        }

        public static unsafe bool GetFrameTimestamp(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> values)
        {
            // SpanOverloader
            return thisApi.GetFrameTimestamp(dpy, surface, frameId, numTimestamps, in timestamps.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe bool GetNextFrameId(this AndroidGetFrameTimestamps thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> frameId)
        {
            // SpanOverloader
            return thisApi.GetNextFrameId(dpy, surface, out frameId.GetPinnableReference());
        }

    }
}

