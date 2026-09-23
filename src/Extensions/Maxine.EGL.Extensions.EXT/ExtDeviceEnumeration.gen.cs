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
using Maxine.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.EXT
{
    [Extension("EXT_device_enumeration")]
    public unsafe partial class ExtDeviceEnumeration : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_enumeration";
        [NativeApi(EntryPoint = "eglQueryDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_devices);

        [NativeApi(EntryPoint = "eglQueryDevicesEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_devices);

        public ExtDeviceEnumeration(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

