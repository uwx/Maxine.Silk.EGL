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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_presentation_time")]
    public unsafe partial class AndroidPresentationTime : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_presentation_time";
        [NativeApi(EntryPoint = "eglPresentationTimeANDROID", Convention = CallingConvention.Winapi)]
        public partial bool PresentationTime([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long time);

        public AndroidPresentationTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

