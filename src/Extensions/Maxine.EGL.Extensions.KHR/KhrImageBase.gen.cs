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
    [Extension("KHR_image_base")]
    public unsafe partial class KhrImageBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_image_base";
        [NativeApi(EntryPoint = "eglCreateImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateImageKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyImageKHR", Convention = CallingConvention.Winapi)]
        public partial bool DestroyImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image);

        public KhrImageBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

