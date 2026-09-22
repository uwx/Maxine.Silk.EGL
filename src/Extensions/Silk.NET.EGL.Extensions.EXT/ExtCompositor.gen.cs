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
    [Extension("EXT_compositor")]
    public unsafe partial class ExtCompositor : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_compositor";
        [NativeApi(EntryPoint = "eglCompositorBindTexWindowEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorBindTexWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id);

        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool CompositorSetContextAttributes([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* context_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextAttributesEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSetContextAttributes([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int context_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool CompositorSetContextList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int* external_ref_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetContextListEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSetContextList([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int external_ref_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetSizeEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSetSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int height);

        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool CompositorSetWindowAttributes([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* window_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowAttributesEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSetWindowAttributes([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int window_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool CompositorSetWindowList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* external_win_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSetWindowListEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSetWindowList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int external_win_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries);

        [NativeApi(EntryPoint = "eglCompositorSwapPolicyEXT", Convention = CallingConvention.Winapi)]
        public partial bool CompositorSwapPolicy([Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int policy);

        public ExtCompositor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

