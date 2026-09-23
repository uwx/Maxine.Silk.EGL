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

namespace Maxine.EGL.Extensions.KHR
{
    [Extension("KHR_debug")]
    public unsafe partial class KhrDebug : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_debug";
        [NativeApi(EntryPoint = "eglDebugMessageControlKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int DebugMessageControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] PfnDebugProcKhr callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglDebugMessageControlKHR", Convention = CallingConvention.Winapi)]
        public partial int DebugMessageControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] PfnDebugProcKhr callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglLabelObjectKHR", Convention = CallingConvention.Winapi)]
        public partial int LabelObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint @object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint label);

        [NativeApi(EntryPoint = "eglQueryDebugKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDebug([Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDebugKHR", Convention = CallingConvention.Winapi)]
        public partial bool QueryDebug([Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        public KhrDebug(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

