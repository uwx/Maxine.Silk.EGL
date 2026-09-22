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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream_attrib")]
    public unsafe partial class KhrStreamAttrib : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_attrib";
        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglSetStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool SetStreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamConsumerAcquireAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerAcquireAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamConsumerReleaseAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerReleaseAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        public KhrStreamAttrib(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

