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
    public static class NVStreamMetadataOverloads
    {
        public static unsafe bool QueryDisplayAttrib(this NVStreamMetadata thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDisplayAttrib(dpy, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryStreamMetadata<T0>(this NVStreamMetadata thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryStreamMetadata(dpy, stream, name, n, offset, size, out data.GetPinnableReference());
        }

        public static unsafe bool SetStreamMetadata<T0>(this NVStreamMetadata thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetStreamMetadata(dpy, stream, n, offset, size, in data.GetPinnableReference());
        }

    }
}

