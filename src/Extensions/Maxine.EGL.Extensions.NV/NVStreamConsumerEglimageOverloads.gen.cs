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

namespace Maxine.EGL.Extensions.NV
{
    public static class NVStreamConsumerEglimageOverloads
    {
        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, @event, out aux.GetPinnableReference());
        }

        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<NV> @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, out @event.GetPinnableReference(), aux);
        }

        public static unsafe int QueryStreamConsumerEvent(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<NV> @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> aux)
        {
            // SpanOverloader
            return thisApi.QueryStreamConsumerEvent(dpy, stream, timeout, out @event.GetPinnableReference(), out aux.GetPinnableReference());
        }

        public static unsafe bool StreamAcquireImage(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pImage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync)
        {
            // SpanOverloader
            return thisApi.StreamAcquireImage(dpy, stream, out pImage.GetPinnableReference(), sync);
        }

        public static unsafe bool StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, modifiers, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, in modifiers.GetPinnableReference(), attrib_list);
        }

        public static unsafe bool StreamImageConsumerConnect(this NVStreamConsumerEglimage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamImageConsumerConnect(dpy, stream, num_modifiers, in modifiers.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

    }
}

