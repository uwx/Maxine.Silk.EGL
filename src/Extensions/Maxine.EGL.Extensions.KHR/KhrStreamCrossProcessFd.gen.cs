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

namespace Maxine.EGL.Extensions.KHR
{
    [Extension("KHR_stream_cross_process_fd")]
    public unsafe partial class KhrStreamCrossProcessFd : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_cross_process_fd";
        [NativeApi(EntryPoint = "eglCreateStreamFromFileDescriptorKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateStreamFromFileDescriptor([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int file_descriptor);

        [NativeApi(EntryPoint = "eglGetStreamFileDescriptorKHR", Convention = CallingConvention.Winapi)]
        public partial int GetStreamFileDescriptor([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        public KhrStreamCrossProcessFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

