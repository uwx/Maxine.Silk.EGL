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
    [Extension("EXT_device_query")]
    public unsafe partial class ExtDeviceQuery : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_device_query";
        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDeviceAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDeviceAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDeviceAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* QueryDeviceString([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglQueryDeviceStringEXT", Convention = CallingConvention.Winapi)]
        public partial string QueryDeviceStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        public ExtDeviceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

