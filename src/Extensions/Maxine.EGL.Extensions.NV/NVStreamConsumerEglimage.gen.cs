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
    [Extension("NV_stream_consumer_eglimage")]
    public unsafe partial class NVStreamConsumerEglimage : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_consumer_eglimage";
        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int QueryStreamConsumerEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int QueryStreamConsumerEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV", Convention = CallingConvention.Winapi)]
        public unsafe partial int QueryStreamConsumerEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV", Convention = CallingConvention.Winapi)]
        public partial int QueryStreamConsumerEvent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV @event, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint aux);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamAcquireImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pImage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV", Convention = CallingConvention.Winapi)]
        public partial bool StreamAcquireImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pImage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamImageConsumerConnect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamImageConsumerConnect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamImageConsumerConnect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV", Convention = CallingConvention.Winapi)]
        public partial bool StreamImageConsumerConnect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamReleaseImageNV", Convention = CallingConvention.Winapi)]
        public partial bool StreamReleaseImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        public NVStreamConsumerEglimage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

