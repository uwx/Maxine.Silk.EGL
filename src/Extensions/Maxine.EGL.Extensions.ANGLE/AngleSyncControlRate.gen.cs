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
    [Extension("ANGLE_sync_control_rate")]
    public unsafe partial class AngleSyncControlRate : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANGLE_sync_control_rate";
        [NativeApi(EntryPoint = "eglGetMscRateANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator);

        [NativeApi(EntryPoint = "eglGetMscRateANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int denominator);

        [NativeApi(EntryPoint = "eglGetMscRateANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator);

        [NativeApi(EntryPoint = "eglGetMscRateANGLE", Convention = CallingConvention.Winapi)]
        public partial bool GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int denominator);

        public AngleSyncControlRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

