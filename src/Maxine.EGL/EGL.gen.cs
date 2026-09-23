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

namespace Maxine.EGL
{
    public unsafe partial class EGL : NativeAPI
    {

        [NativeApi(EntryPoint = "eglClientWaitSync", Convention = CallingConvention.Winapi)]
        public partial int ClientWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateImage", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateImage", Convention = CallingConvention.Winapi)]
        public partial nint CreateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformPixmapSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface", Convention = CallingConvention.Winapi)]
        public partial nint CreatePlatformPixmapSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePlatformWindowSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface", Convention = CallingConvention.Winapi)]
        public partial nint CreatePlatformWindowSurface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreateSync", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateSync", Convention = CallingConvention.Winapi)]
        public partial nint CreateSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglDestroyImage", Convention = CallingConvention.Winapi)]
        public partial bool DestroyImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image);

        [NativeApi(EntryPoint = "eglDestroySync", Convention = CallingConvention.Winapi)]
        public partial bool DestroySync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay", Convention = CallingConvention.Winapi)]
        public unsafe partial nint GetPlatformDisplay<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplay", Convention = CallingConvention.Winapi)]
        public partial nint GetPlatformDisplay<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum platform, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 native_display, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetSyncAttrib", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetSyncAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglGetSyncAttrib", Convention = CallingConvention.Winapi)]
        public partial bool GetSyncAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglWaitSync", Convention = CallingConvention.Winapi)]
        public partial bool WaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int flags);

        [NativeApi(EntryPoint = "eglGetCurrentContext", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentContext();

        [NativeApi(EntryPoint = "eglBindAPI", Convention = CallingConvention.Winapi)]
        public partial bool BindApi([Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum api);

        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePbufferFromClientBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum buftype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer", Convention = CallingConvention.Winapi)]
        public partial nint CreatePbufferFromClientBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EGLEnum buftype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglQueryAPI", Convention = CallingConvention.Winapi)]
        public partial EGLEnum QueryApi();

        [NativeApi(EntryPoint = "eglReleaseThread", Convention = CallingConvention.Winapi)]
        public partial bool ReleaseThread();

        [NativeApi(EntryPoint = "eglWaitClient", Convention = CallingConvention.Winapi)]
        public partial bool WaitClient();

        [NativeApi(EntryPoint = "eglBindTexImage", Convention = CallingConvention.Winapi)]
        public partial bool BindTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int buffer);

        [NativeApi(EntryPoint = "eglReleaseTexImage", Convention = CallingConvention.Winapi)]
        public partial bool ReleaseTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int buffer);

        [NativeApi(EntryPoint = "eglSurfaceAttrib", Convention = CallingConvention.Winapi)]
        public partial bool SurfaceAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "eglSwapInterval", Convention = CallingConvention.Winapi)]
        public partial bool SwapInterval([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int interval);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public unsafe partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig", Convention = CallingConvention.Winapi)]
        public partial bool ChooseConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglCopyBuffers", Convention = CallingConvention.Winapi)]
        public partial bool CopyBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint target);

        [NativeApi(EntryPoint = "eglCreateContext", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint share_context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint share_context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePbufferSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferSurface", Convention = CallingConvention.Winapi)]
        public partial nint CreatePbufferSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePixmapSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreatePixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePixmapSurface", Convention = CallingConvention.Winapi)]
        public partial nint CreatePixmapSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pixmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglCreateWindowSurface", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint win, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateWindowSurface", Convention = CallingConvention.Winapi)]
        public partial nint CreateWindowSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint win, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyContext", Convention = CallingConvention.Winapi)]
        public partial bool DestroyContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx);

        [NativeApi(EntryPoint = "eglDestroySurface", Convention = CallingConvention.Winapi)]
        public partial bool DestroySurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "eglGetConfigAttrib", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetConfigAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetConfigAttrib", Convention = CallingConvention.Winapi)]
        public partial bool GetConfigAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint config, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglGetConfigs", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetConfigs([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglGetConfigs", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetConfigs([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglGetConfigs", Convention = CallingConvention.Winapi)]
        public unsafe partial bool GetConfigs([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglGetConfigs", Convention = CallingConvention.Winapi)]
        public partial bool GetConfigs([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint configs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int config_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglGetCurrentDisplay", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentDisplay();

        [NativeApi(EntryPoint = "eglGetCurrentSurface", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] int readdraw);

        [NativeApi(EntryPoint = "eglGetDisplay", Convention = CallingConvention.Winapi)]
        public partial nint GetDisplay([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint display_id);

        [NativeApi(EntryPoint = "eglGetError", Convention = CallingConvention.Winapi)]
        public partial int GetError();

        [NativeApi(EntryPoint = "eglGetProcAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetProcAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* procname);

        [NativeApi(EntryPoint = "eglGetProcAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetProcAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte procname);

        [NativeApi(EntryPoint = "eglGetProcAddress", Convention = CallingConvention.Winapi)]
        public unsafe partial void* GetProcAddress([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procname);

        [NativeApi(EntryPoint = "eglInitialize", Convention = CallingConvention.Winapi)]
        public unsafe partial bool Initialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* major, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* minor);

        [NativeApi(EntryPoint = "eglInitialize", Convention = CallingConvention.Winapi)]
        public unsafe partial bool Initialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* major, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int minor);

        [NativeApi(EntryPoint = "eglInitialize", Convention = CallingConvention.Winapi)]
        public unsafe partial bool Initialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int major, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* minor);

        [NativeApi(EntryPoint = "eglInitialize", Convention = CallingConvention.Winapi)]
        public partial bool Initialize([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int major, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int minor);

        [NativeApi(EntryPoint = "eglMakeCurrent", Convention = CallingConvention.Winapi)]
        public partial bool MakeCurrent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint draw, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint read, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx);

        [NativeApi(EntryPoint = "eglQueryContext", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QueryContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryContext", Convention = CallingConvention.Winapi)]
        public partial bool QueryContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryString", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* QueryString([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "eglQueryString", Convention = CallingConvention.Winapi)]
        public partial string QueryStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQuerySurface", Convention = CallingConvention.Winapi)]
        public unsafe partial bool QuerySurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQuerySurface", Convention = CallingConvention.Winapi)]
        public partial bool QuerySurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int attribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglSwapBuffers", Convention = CallingConvention.Winapi)]
        public partial bool SwapBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "eglTerminate", Convention = CallingConvention.Winapi)]
        public partial bool Terminate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglWaitGL", Convention = CallingConvention.Winapi)]
        public partial bool WaitGL();

        [NativeApi(EntryPoint = "eglWaitNative", Convention = CallingConvention.Winapi)]
        public partial bool WaitNative([Flow(Silk.NET.Core.Native.FlowDirection.In)] int engine);


        public EGL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

