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

namespace Maxine.EGL.Extensions.NV
{
    [Extension("NV_stream_metadata")]
    public unsafe partial class NVStreamMetadata : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_metadata";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV", Convention = CallingConvention.Winapi)]
        public partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryStreamMetadata([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV", Convention = CallingConvention.Winapi)]
        public partial bool QueryStreamMetadata<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool SetStreamMetadata([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV", Convention = CallingConvention.Winapi)]
        public partial bool SetStreamMetadata<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data) where T0 : unmanaged;

        public NVStreamMetadata(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

