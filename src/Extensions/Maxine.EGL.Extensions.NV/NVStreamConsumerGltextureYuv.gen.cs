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
    [Extension("NV_stream_consumer_gltexture_yuv")]
    public unsafe partial class NVStreamConsumerGltextureYuv : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_consumer_gltexture_yuv";
        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool StreamConsumerGltextureExternalAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerGltextureExternalAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        public NVStreamConsumerGltextureYuv(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

