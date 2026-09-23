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

namespace Maxine.EGL.Extensions.NV
{
    public static class NVSyncOverloads
    {
        public static unsafe nint CreateFenceSync(this NVSync thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateFenceSync(dpy, condition, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool GetSyncAttrib(this NVSync thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> value)
        {
            // SpanOverloader
            return thisApi.GetSyncAttrib(sync, attribute, out value.GetPinnableReference());
        }

    }
}

