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

namespace Maxine.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_get_frame_timestamps")]
    public unsafe partial class AndroidGetFrameTimestamps : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_frame_timestamps";
        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetCompositorTiming([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetCompositorTiming([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetCompositorTiming([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingANDROID", Convention = CallingConvention.Winapi)]
        public partial bool GetCompositorTiming([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int names, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetCompositorTimingSupportedANDROID", Convention = CallingConvention.Winapi)]
        public partial bool GetCompositorTimingSupporte([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetFrameTimestamp([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetFrameTimestamp([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetFrameTimestamp([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampsANDROID", Convention = CallingConvention.Winapi)]
        public partial bool GetFrameTimestamp([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numTimestamps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int timestamps, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long values);

        [NativeApi(EntryPoint = "eglGetFrameTimestampSupportedANDROID", Convention = CallingConvention.Winapi)]
        public partial bool GetFrameTimestampSupporte([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int timestamp);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetNextFrameId([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* frameId);

        [NativeApi(EntryPoint = "eglGetNextFrameIdANDROID", Convention = CallingConvention.Winapi)]
        public partial bool GetNextFrameId([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong frameId);

        public AndroidGetFrameTimestamps(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

