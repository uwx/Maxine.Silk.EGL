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

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.MESA
{
    public static class MesaImageDmaBufExportOverloads
    {
        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, strides, out offsets.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, out strides.GetPinnableReference(), offsets);
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, fds, out strides.GetPinnableReference(), out offsets.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), strides, offsets);
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), strides, out offsets.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), out strides.GetPinnableReference(), offsets);
        }

        public static unsafe bool ExportDmabufimage(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fds, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> strides, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> offsets)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimage(dpy, image, out fds.GetPinnableReference(), out strides.GetPinnableReference(), out offsets.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, num_planes, out modifiers.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, out num_planes.GetPinnableReference(), modifiers);
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, fourcc, out num_planes.GetPinnableReference(), out modifiers.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), num_planes, modifiers);
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), num_planes, out modifiers.GetPinnableReference());
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), out num_planes.GetPinnableReference(), modifiers);
        }

        public static unsafe bool ExportDmabufimageQuery(this MesaImageDmaBufExport thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> fourcc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_planes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers)
        {
            // SpanOverloader
            return thisApi.ExportDmabufimageQuery(dpy, image, out fourcc.GetPinnableReference(), out num_planes.GetPinnableReference(), out modifiers.GetPinnableReference());
        }

    }
}

