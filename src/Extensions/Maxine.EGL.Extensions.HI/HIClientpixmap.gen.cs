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

namespace Maxine.EGL.Extensions.HI
{
    [Extension("HI_clientpixmap")]
    public unsafe partial class HIClientpixmap : NativeExtension<EGL>
    {
        public const string ExtensionName = "HI_clientpixmap";
        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePixmapSurfaceHI([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ClientPixmapHI* pixmap);

        [NativeApi(EntryPoint = "eglCreatePixmapSurfaceHI", Convention = CallingConvention.Winapi)]
        public partial nint CreatePixmapSurfaceHI([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ClientPixmapHI pixmap);

        public HIClientpixmap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

