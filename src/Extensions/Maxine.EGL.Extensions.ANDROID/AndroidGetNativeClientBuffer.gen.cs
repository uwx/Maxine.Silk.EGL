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
using Maxine.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Maxine.EGL.Extensions.ANDROID
{
    [Extension("ANDROID_get_native_client_buffer")]
    public unsafe partial class AndroidGetNativeClientBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_get_native_client_buffer";
        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetNativeClientBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer);

        [NativeApi(EntryPoint = "eglGetNativeClientBufferANDROID", Convention = CallingConvention.Winapi)]
        public partial nint GetNativeClientBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint buffer);

        public AndroidGetNativeClientBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

