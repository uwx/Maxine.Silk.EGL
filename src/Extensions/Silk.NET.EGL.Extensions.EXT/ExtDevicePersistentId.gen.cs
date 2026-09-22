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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_device_persistent_id")]
    public unsafe partial class ExtDevicePersistentId : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_persistent_id";
        [NativeApi(EntryPoint = "eglQueryDeviceBinaryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDeviceBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size);

        [NativeApi(EntryPoint = "eglQueryDeviceBinaryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDeviceBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size);

        [NativeApi(EntryPoint = "eglQueryDeviceBinaryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDeviceBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglQueryDeviceBinaryEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDeviceBinary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size) where T0 : unmanaged;

        public ExtDevicePersistentId(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

