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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_image_dma_buf_import_modifiers")]
    public unsafe partial class ExtImageDmaBufImportModifiers : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_image_dma_buf_import_modifiers";
        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDmaBufFormats([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryDmaBufModifiers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong modifiers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool external_only, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_modifiers);

        public ExtImageDmaBufImportModifiers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

