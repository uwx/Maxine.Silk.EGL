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
    [Extension("EXT_output_base")]
    public unsafe partial class ExtOutputBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_output_base";
        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT", Convention = CallingConvention.Winapi)]
        public partial bool GetOutputLayers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint layers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_layers, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT", Convention = CallingConvention.Winapi)]
        public partial bool GetOutputPorts([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint ports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int max_ports, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglOutputLayerAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool OutputLayerAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglOutputPortAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool OutputPortAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryOutputLayerAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryOutputLayerAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* QueryOutputLayerString([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT", Convention = CallingConvention.Winapi)]
        public partial string QueryOutputLayerStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryOutputPortAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT", Convention = CallingConvention.Winapi)]
        public partial bool QueryOutputPortAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* QueryOutputPortString([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT", Convention = CallingConvention.Winapi)]
        public partial string QueryOutputPortStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint port, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        public ExtOutputBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

