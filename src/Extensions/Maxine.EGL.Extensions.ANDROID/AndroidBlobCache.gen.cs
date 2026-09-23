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
    [Extension("ANDROID_blob_cache")]
    public unsafe partial class AndroidBlobCache : NativeExtension<EGL>
    {
        public const string ExtensionName = "ANDROID_blob_cache";
        [NativeApi(EntryPoint = "eglSetBlobCacheFuncsANDROID", Convention = CallingConvention.Winapi)]
        public partial void SetBlobCacheFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PfnSetBlobFuncANDROID set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PfnGetBlobFuncANDROID get);

        public AndroidBlobCache(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

