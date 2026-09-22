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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_lock_surface3")]
    public unsafe partial class KhrLockSurface3 : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_lock_surface3";
        [NativeApi(EntryPoint = "eglLockSurfaceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool LockSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglLockSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial bool LockSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglQuerySurface64KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySurface64([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQuerySurface64KHR", Convention = CallingConvention.Winapi)]
        public partial bool QuerySurface64([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglUnlockSurfaceKHR", Convention = CallingConvention.Winapi)]
        public partial bool UnlockSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface);

        public KhrLockSurface3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

