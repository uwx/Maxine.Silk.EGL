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
    [Extension("WL_bind_wayland_display")]
    public unsafe partial class WLBindWaylandDisplay : NativeExtension<EGL>
    {
        public const string ExtensionName = "WL_bind_wayland_display";
        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL", Convention = CallingConvention.Winapi)]
        public unsafe partial bool BindWaylandDisplayWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* display);

        [NativeApi(EntryPoint = "eglBindWaylandDisplayWL", Convention = CallingConvention.Winapi)]
        public partial bool BindWaylandDisplayWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint display);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryWaylandBufferWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryWaylandBufferWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryWaylandBufferWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryWaylandBufferWL", Convention = CallingConvention.Winapi)]
        public partial bool QueryWaylandBufferWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL", Convention = CallingConvention.Winapi)]
        public unsafe partial bool UnbindWaylandDisplayWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* display);

        [NativeApi(EntryPoint = "eglUnbindWaylandDisplayWL", Convention = CallingConvention.Winapi)]
        public partial bool UnbindWaylandDisplayWL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint display);

        public WLBindWaylandDisplay(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

