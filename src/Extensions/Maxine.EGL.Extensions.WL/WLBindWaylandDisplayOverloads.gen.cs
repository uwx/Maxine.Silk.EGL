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

namespace Maxine.EGL.Extensions.WL
{
    public static class WLBindWaylandDisplayOverloads
    {
        public static unsafe bool BindWaylandDisplayWL(this WLBindWaylandDisplay thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> display)
        {
            // SpanOverloader
            return thisApi.BindWaylandDisplayWL(dpy, out display.GetPinnableReference());
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, buffer, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, out buffer.GetPinnableReference(), attribute, value);
        }

        public static unsafe bool QueryWaylandBufferWL(this WLBindWaylandDisplay thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryWaylandBufferWL(dpy, out buffer.GetPinnableReference(), attribute, out value.GetPinnableReference());
        }

        public static unsafe bool UnbindWaylandDisplayWL(this WLBindWaylandDisplay thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> display)
        {
            // SpanOverloader
            return thisApi.UnbindWaylandDisplayWL(dpy, out display.GetPinnableReference());
        }

    }
}

