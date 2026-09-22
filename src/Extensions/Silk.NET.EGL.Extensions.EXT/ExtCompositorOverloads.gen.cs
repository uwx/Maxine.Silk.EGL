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
    public static class ExtCompositorOverloads
    {
        public static unsafe bool CompositorSetContextAttributes(this ExtCompositor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> context_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetContextAttributes(external_ref_id, in context_attributes.GetPinnableReference(), num_entries);
        }

        public static unsafe bool CompositorSetContextList(this ExtCompositor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> external_ref_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetContextList(in external_ref_ids.GetPinnableReference(), num_entries);
        }

        public static unsafe bool CompositorSetWindowAttributes(this ExtCompositor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_win_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> window_attributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetWindowAttributes(external_win_id, in window_attributes.GetPinnableReference(), num_entries);
        }

        public static unsafe bool CompositorSetWindowList(this ExtCompositor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int external_ref_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> external_win_ids, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int num_entries)
        {
            // SpanOverloader
            return thisApi.CompositorSetWindowList(external_ref_id, in external_win_ids.GetPinnableReference(), num_entries);
        }

    }
}

