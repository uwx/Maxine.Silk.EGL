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

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtSurfaceCompressionOverloads
    {
        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, attrib_list, rates, rate_size, out num_rates.GetPinnableReference());
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, attrib_list, out rates.GetPinnableReference(), rate_size, num_rates);
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, attrib_list, out rates.GetPinnableReference(), rate_size, out num_rates.GetPinnableReference());
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, in attrib_list.GetPinnableReference(), rates, rate_size, num_rates);
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, in attrib_list.GetPinnableReference(), rates, rate_size, out num_rates.GetPinnableReference());
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, in attrib_list.GetPinnableReference(), out rates.GetPinnableReference(), rate_size, num_rates);
        }

        public static unsafe bool QuerySupportedCompressionRates(this ExtSurfaceCompression thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_rates)
        {
            // SpanOverloader
            return thisApi.QuerySupportedCompressionRates(dpy, config, in attrib_list.GetPinnableReference(), out rates.GetPinnableReference(), rate_size, out num_rates.GetPinnableReference());
        }

    }
}

