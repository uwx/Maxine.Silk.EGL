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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_stream_reset")]
    public unsafe partial class NVStreamReset : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_reset";
        [NativeApi(EntryPoint = "eglResetStreamNV", Convention = CallingConvention.Winapi)]
        public partial bool ResetStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream);

        public NVStreamReset(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

