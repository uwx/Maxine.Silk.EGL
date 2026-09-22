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
    [Extension("KHR_display_reference")]
    public unsafe partial class KhrDisplayReference : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_display_reference";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribKHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryDisplayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        public KhrDisplayReference(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

