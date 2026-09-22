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
    [Extension("EXT_platform_base")]
    public unsafe partial class ExtPlatformBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_platform_base";
        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurfaceEXT", Convention = CallingConvention.Winapi)]
        public partial nint CreatePlatformPixmapSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurfaceEXT", Convention = CallingConvention.Winapi)]
        public partial nint CreatePlatformWindowSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplayEXT", Convention = CallingConvention.Winapi)]
        public partial nint GetPlatformDisplay<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list) where T0 : unmanaged;

        public ExtPlatformBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

