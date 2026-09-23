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

namespace Maxine.EGL.Extensions.NOK
{
    [Extension("NOK_swap_region2")]
    public unsafe partial class NokSwapRegion2 : NativeExtension<EGL>
    {
        public const string ExtensionName = "NOK_swap_region2";
        [NativeApi(EntryPoint = "eglSwapBuffersRegion2NOK", Convention = CallingConvention.Winapi)]
        public unsafe partial bool SwapBuffersRegion2Nok([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* rects);

        [NativeApi(EntryPoint = "eglSwapBuffersRegion2NOK", Convention = CallingConvention.Winapi)]
        public partial bool SwapBuffersRegion2Nok([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int rects);

        public NokSwapRegion2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

