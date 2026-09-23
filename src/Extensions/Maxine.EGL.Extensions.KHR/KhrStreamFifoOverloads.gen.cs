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

namespace Maxine.EGL.Extensions.KHR
{
    public static class KhrStreamFifoOverloads
    {
        public static unsafe bool QueryStreamTime(this KhrStreamFifo thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] KHR attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> value)
        {
            // SpanOverloader
            return thisApi.QueryStreamTime(dpy, stream, attribute, out value.GetPinnableReference());
        }

    }
}

