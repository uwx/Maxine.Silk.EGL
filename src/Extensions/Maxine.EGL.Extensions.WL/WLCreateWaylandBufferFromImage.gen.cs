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

namespace Maxine.EGL.Extensions.WL
{
    [Extension("WL_create_wayland_buffer_from_image")]
    public unsafe partial class WLCreateWaylandBufferFromImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "WL_create_wayland_buffer_from_image";
        [NativeApi(EntryPoint = "eglCreateWaylandBufferFromImageWL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint* CreateWaylandBufferFromImageWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image);

        public WLCreateWaylandBufferFromImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

