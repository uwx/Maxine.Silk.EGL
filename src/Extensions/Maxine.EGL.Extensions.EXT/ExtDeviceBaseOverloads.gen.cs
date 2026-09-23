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
    public static class ExtDeviceBaseOverloads
    {
        public static unsafe bool QueryDeviceAttrib(this ExtDeviceBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDeviceAttrib(device, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe bool QueryDisplayAttrib(this ExtDeviceBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDisplayAttrib(dpy, attribute, out value.GetPinnableReference());
        }

    }
}

