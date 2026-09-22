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
    [Extension("KHR_stream_fifo")]
    public unsafe partial class KhrStreamFifo : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_fifo";
        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryStreamTime([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryStreamTime([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong value);

        public KhrStreamFifo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

