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

namespace Maxine.EGL.Extensions.EXT
{
    public static class ExtOutputBaseOverloads
    {
        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, layers, max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, out layers.GetPinnableReference(), max_layers, num_layers);
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, out layers.GetPinnableReference(), max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), layers, max_layers, num_layers);
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), layers, max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), out layers.GetPinnableReference(), max_layers, num_layers);
        }

        public static unsafe bool GetOutputLayers(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), out layers.GetPinnableReference(), max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, ports, max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, out ports.GetPinnableReference(), max_ports, num_ports);
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, out ports.GetPinnableReference(), max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), ports, max_ports, num_ports);
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), ports, max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), out ports.GetPinnableReference(), max_ports, num_ports);
        }

        public static unsafe bool GetOutputPorts(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), out ports.GetPinnableReference(), max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe bool QueryOutputLayerAttrib(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryOutputLayerAttrib(dpy, layer, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryOutputPortAttrib(this ExtOutputBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryOutputPortAttrib(dpy, port, attribute, out value.GetPinnableReference());
        }

    }
}

