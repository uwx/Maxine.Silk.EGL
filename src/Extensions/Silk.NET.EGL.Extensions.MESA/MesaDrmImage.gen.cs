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

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_drm_image")]
    public unsafe partial class MesaDrmImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_drm_image";
        [NativeApi(EntryPoint = "eglCreateDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateDRMImageMESA", Convention = CallingConvention.Winapi)]
        public partial nint CreateDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA", Convention = CallingConvention.Winapi)]
        public partial bool ExportDrmimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride);

        public MesaDrmImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

