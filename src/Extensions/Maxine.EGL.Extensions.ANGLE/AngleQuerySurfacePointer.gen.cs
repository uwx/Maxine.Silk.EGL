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

namespace Maxine.EGL.Extensions.ANGLE
{
    [Extension("ANGLE_query_surface_pointer")]
    public unsafe partial class AngleQuerySurfacePointer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANGLE_query_surface_pointer";
        [NativeApi(EntryPoint = "eglQuerySurfacePointerANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySurfacePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** value);

        [NativeApi(EntryPoint = "eglQuerySurfacePointerANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySurfacePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* value);

        public AngleQuerySurfacePointer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

