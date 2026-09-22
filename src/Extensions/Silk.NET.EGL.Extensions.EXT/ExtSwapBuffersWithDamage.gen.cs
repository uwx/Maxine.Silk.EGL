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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_swap_buffers_with_damage")]
    public unsafe partial class ExtSwapBuffersWithDamage : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_swap_buffers_with_damage";
        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool SwapBuffersWithDamage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* rects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n_rects);

        [NativeApi(EntryPoint = "eglSwapBuffersWithDamageEXT", Convention = CallingConvention.Winapi)]
        public partial bool SwapBuffersWithDamage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int rects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n_rects);

        public ExtSwapBuffersWithDamage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

