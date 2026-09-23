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
    [Extension("NV_post_sub_buffer")]
    public unsafe partial class NVPostSubBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_post_sub_buffer";
        [NativeApi(EntryPoint = "eglPostSubBufferNV", Convention = CallingConvention.Winapi)]
        public partial bool PostSubBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int height);

        public NVPostSubBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

