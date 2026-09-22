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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_system_time")]
    public unsafe partial class NVSystemTime : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_system_time";
        [NativeApi(EntryPoint = "eglGetSystemTimeNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetSystemTime();

        [NativeApi(EntryPoint = "eglGetSystemTimeFrequencyNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetSystemTimeFrequency();

        public NVSystemTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

