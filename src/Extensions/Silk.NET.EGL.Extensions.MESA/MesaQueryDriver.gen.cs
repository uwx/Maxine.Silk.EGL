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

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_query_driver")]
    public unsafe partial class MesaQueryDriver : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_query_driver";
        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* GetDisplayDriverConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig", Convention = CallingConvention.Winapi)]
        public partial string GetDisplayDriverConfigS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverName", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* GetDisplayDriverName([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglGetDisplayDriverName", Convention = CallingConvention.Winapi)]
        public partial string GetDisplayDriverNameS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy);

        public MesaQueryDriver(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

