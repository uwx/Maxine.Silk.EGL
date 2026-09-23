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
    [Extension("NV_sync")]
    public unsafe partial class NVSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_sync";
        [NativeApi(EntryPoint = "eglClientWaitSyncNV", Convention = CallingConvention.Winapi)]
        public partial int ClientWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateFenceSyncNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFenceSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateFenceSyncNV", Convention = CallingConvention.Winapi)]
        public partial nint CreateFenceSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglDestroySyncNV", Convention = CallingConvention.Winapi)]
        public partial bool DestroySync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglFenceNV", Convention = CallingConvention.Winapi)]
        public partial bool Fence([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglGetSyncAttribNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetSyncAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetSyncAttribNV", Convention = CallingConvention.Winapi)]
        public partial bool GetSyncAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglSignalSyncNV", Convention = CallingConvention.Winapi)]
        public partial bool SignalSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        public NVSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

