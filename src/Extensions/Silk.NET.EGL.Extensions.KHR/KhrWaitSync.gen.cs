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
    [Extension("KHR_wait_sync")]
    public unsafe partial class KhrWaitSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_wait_sync";
        [NativeApi(EntryPoint = "eglWaitSyncKHR", Convention = CallingConvention.Winapi)]
        public partial int WaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int flags);

        public KhrWaitSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

