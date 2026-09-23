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

namespace Maxine.EGL.Extensions.EXT
{
    [Extension("EXT_stream_consumer_egloutput")]
    public unsafe partial class ExtStreamConsumerEgloutput : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_stream_consumer_egloutput";
        [NativeApi(EntryPoint = "eglStreamConsumerOutputEXT", Convention = CallingConvention.Winapi)]
        public partial bool StreamConsumerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer);

        public ExtStreamConsumerEgloutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

