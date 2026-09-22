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

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public static class AndroidGetNativeClientBufferOverloads
    {
        public static unsafe nint GetNativeClientBuffer(this AndroidGetNativeClientBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> buffer)
        {
            // SpanOverloader
            return thisApi.GetNativeClientBuffer(in buffer.GetPinnableReference());
        }

    }
}

