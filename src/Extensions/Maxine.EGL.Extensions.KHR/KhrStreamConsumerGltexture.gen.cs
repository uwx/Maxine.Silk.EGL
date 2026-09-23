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
    [Extension("KHR_stream_consumer_gltexture")]
    public unsafe partial class KhrStreamConsumerGltexture : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_consumer_gltexture";
        [NativeApi(EntryPoint = "eglStreamConsumerAcquireKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerAcquire([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerGltextureExternal([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseKHR", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerRelease([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        public KhrStreamConsumerGltexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

