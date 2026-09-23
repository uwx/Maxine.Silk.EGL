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
    [Extension("EXT_sync_reuse")]
    public unsafe partial class ExtSyncReuse : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_sync_reuse";
        [NativeApi(EntryPoint = "eglUnsignalSyncEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool UnsignalSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglUnsignalSyncEXT", Convention = CallingConvention.Winapi)]
        public partial bool UnsignalSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        public ExtSyncReuse(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

