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

namespace Maxine.EGL.Extensions.HI
{
    public static class HIClientpixmapOverloads
    {
        public static unsafe nint CreatePixmapSurfaceHI(this HIClientpixmap thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ClientPixmapHI> pixmap)
        {
            // SpanOverloader
            return thisApi.CreatePixmapSurfaceHI(dpy, config, out pixmap.GetPinnableReference());
        }

    }
}

