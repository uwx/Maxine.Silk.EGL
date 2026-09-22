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
    [Extension("KHR_stream")]
    public unsafe partial class KhrStream : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream";
        [NativeApi(EntryPoint = "eglCreateStreamKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyStreamKHR", Convention = CallingConvention.Winapi)]
        public partial bool DestroyStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglQueryStreamKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryStreamKHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryStreamu64([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryStreamu64([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong value);

        [NativeApi(EntryPoint = "eglStreamAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        public KhrStream(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

