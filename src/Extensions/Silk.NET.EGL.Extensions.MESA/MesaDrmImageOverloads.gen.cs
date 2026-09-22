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

namespace Silk.NET.EGL.Extensions.MESA
{
    public static class MesaDrmImageOverloads
    {
        public static unsafe nint CreateDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateDrmimage(dpy, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, handle, out stride.GetPinnableReference());
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, out handle.GetPinnableReference(), stride);
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, name, out handle.GetPinnableReference(), out stride.GetPinnableReference());
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), handle, stride);
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), handle, out stride.GetPinnableReference());
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), out handle.GetPinnableReference(), stride);
        }

        public static unsafe bool ExportDrmimage(this MesaDrmImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> name, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> handle, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride)
        {
            // SpanOverloader
            return thisApi.ExportDrmimage(dpy, image, out name.GetPinnableReference(), out handle.GetPinnableReference(), out stride.GetPinnableReference());
        }

    }
}

