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
    [Extension("MESA_image_dma_buf_export")]
    public unsafe partial class MesaImageDmaBufExport : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_image_dma_buf_export";
        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA", Convention = CallingConvention.Winapi)]
        public partial bool ExportDmabufimage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA", Convention = CallingConvention.Winapi)]
        public partial bool ExportDmabufimageQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers);

        public MesaImageDmaBufExport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

