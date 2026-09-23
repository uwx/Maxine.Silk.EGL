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

namespace Maxine.EGL.Extensions.EXT
{
    [Extension("EXT_surface_compression")]
    public unsafe partial class ExtSurfaceCompression : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_surface_compression";
        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_rates);

        [NativeApi(EntryPoint = "eglQuerySupportedCompressionRatesEXT", Convention = CallingConvention.Winapi)]
        public partial bool QuerySupportedCompressionRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int rates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int rate_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_rates);

        public ExtSurfaceCompression(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

