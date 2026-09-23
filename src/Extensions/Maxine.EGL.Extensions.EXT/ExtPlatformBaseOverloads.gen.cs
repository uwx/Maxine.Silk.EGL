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

namespace Maxine.EGL.Extensions.EXT
{
    public static class ExtPlatformBaseOverloads
    {
        public static unsafe nint CreatePlatformPixmapSurface(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, native_pixmap, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformPixmapSurface<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformPixmapSurface(dpy, config, out native_pixmap.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, native_window, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint CreatePlatformWindowSurface<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreatePlatformWindowSurface(dpy, config, out native_window.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, native_display, in attrib_list.GetPinnableReference());
        }

        public static unsafe nint GetPlatformDisplay<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), attrib_list);
        }

        public static unsafe nint GetPlatformDisplay<T0>(this ExtPlatformBase thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPlatformDisplay(platform, out native_display.GetPinnableReference(), in attrib_list.GetPinnableReference());
        }

    }
}

