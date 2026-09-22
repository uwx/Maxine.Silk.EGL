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

namespace Silk.NET.EGL.Extensions.NOK
{
    [Extension("NOK_swap_region")]
    public unsafe partial class NokSwapRegion : NativeExtension<EGL>
    {
        public const string ExtensionName = "NOK_swap_region";
        [NativeApi(EntryPoint = "eglSwapBuffersRegionNOK", Convention = CallingConvention.Winapi)]
        public unsafe partial bool SwapBuffersRegionNok([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* rects);

        [NativeApi(EntryPoint = "eglSwapBuffersRegionNOK", Convention = CallingConvention.Winapi)]
        public partial bool SwapBuffersRegionNok([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int rects);

        public NokSwapRegion(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

