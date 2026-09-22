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

namespace Silk.NET.EGL.Extensions.NV
{
    public static class NVNativeQueryOverloads
    {
        public static unsafe bool QueryNativeDisplay(this NVNativeQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> display_id)
        {
            // SpanOverloader
            return thisApi.QueryNativeDisplay(dpy, out display_id.GetPinnableReference());
        }

        public static unsafe bool QueryNativePixmap(this NVNativeQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pixmap)
        {
            // SpanOverloader
            return thisApi.QueryNativePixmap(dpy, surf, out pixmap.GetPinnableReference());
        }

        public static unsafe bool QueryNativeWindow(this NVNativeQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surf, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> window)
        {
            // SpanOverloader
            return thisApi.QueryNativeWindow(dpy, surf, out window.GetPinnableReference());
        }

    }
}

