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

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtImageDmaBufImportModifiersOverloads
    {
        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, formats, out num_formats.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, out formats.GetPinnableReference(), num_formats);
        }

        public static unsafe bool QueryDmaBufFormats(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_formats)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufFormats(dpy, max_formats, out formats.GetPinnableReference(), out num_formats.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, external_only, out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, out external_only.GetPinnableReference(), num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, modifiers, out external_only.GetPinnableReference(), out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), external_only, num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), external_only, out num_modifiers.GetPinnableReference());
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), out external_only.GetPinnableReference(), num_modifiers);
        }

        public static unsafe bool QueryDmaBufModifiers(this ExtImageDmaBufImportModifiers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<bool> external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> num_modifiers)
        {
            // SpanOverloader
            return thisApi.QueryDmaBufModifiers(dpy, format, max_modifiers, out modifiers.GetPinnableReference(), out external_only.GetPinnableReference(), out num_modifiers.GetPinnableReference());
        }

    }
}

