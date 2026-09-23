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
    public static class ExtDevicePersistentIdOverloads
    {
        public static unsafe bool QueryDeviceBinary(this ExtDevicePersistentId thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size)
        {
            // SpanOverloader
            return thisApi.QueryDeviceBinary(device, name, max_size, value, out size.GetPinnableReference());
        }

        public static unsafe bool QueryDeviceBinary<T0>(this ExtDevicePersistentId thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryDeviceBinary(device, name, max_size, out value.GetPinnableReference(), size);
        }

        public static unsafe bool QueryDeviceBinary<T0>(this ExtDevicePersistentId thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryDeviceBinary(device, name, max_size, out value.GetPinnableReference(), out size.GetPinnableReference());
        }

    }
}

