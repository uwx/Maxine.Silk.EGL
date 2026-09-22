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
    [Extension("EXT_client_sync")]
    public unsafe partial class ExtClientSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_client_sync";
        [NativeApi(EntryPoint = "eglClientSignalSyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ClientSignalSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglClientSignalSyncEXT", Convention = CallingConvention.Winapi)]
        public partial bool ClientSignalSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        public ExtClientSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

