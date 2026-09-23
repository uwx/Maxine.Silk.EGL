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
    public static class KhrStreamOverloads
    {
        public static unsafe nint CreateStream(this KhrStream thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateStream(dpy, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool QueryStream(this KhrStream thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.QueryStream(dpy, stream, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryStreamu64(this KhrStream thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> value)
        {
            // SpanOverloader
            return thisApi.QueryStreamu64(dpy, stream, attribute, out value.GetPinnableReference());
        }

    }
}

