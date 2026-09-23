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
    [Extension("NV_native_query")]
    public unsafe partial class NVNativeQuery : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_native_query";
        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryNativeDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* display_id);

        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV", Convention = CallingConvention.Winapi)]
        public partial bool QueryNativeDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint display_id);

        [NativeApi(EntryPoint = "eglQueryNativePixmapNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryNativePixmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pixmap);

        [NativeApi(EntryPoint = "eglQueryNativePixmapNV", Convention = CallingConvention.Winapi)]
        public partial bool QueryNativePixmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pixmap);

        [NativeApi(EntryPoint = "eglQueryNativeWindowNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryNativeWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* window);

        [NativeApi(EntryPoint = "eglQueryNativeWindowNV", Convention = CallingConvention.Winapi)]
        public partial bool QueryNativeWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint window);

        public NVNativeQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

