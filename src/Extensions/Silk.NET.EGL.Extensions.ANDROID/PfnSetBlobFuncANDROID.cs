// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Silk.NET.EGL.Extensions.ANDROID
{
    /// <summary>
    /// A function pointer for <c>EGLSetBlobFuncANDROID</c>, passed to <c>eglSetBlobCacheFuncsANDROID</c>.
    /// </summary>
    public readonly unsafe struct PfnSetBlobFuncANDROID : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, int, void*, int, void> Handle =>
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void>) _handle;

        public PfnSetBlobFuncANDROID
        (
            delegate* unmanaged[Cdecl]<void*, int, void*, int, void> ptr
        ) => _handle = ptr;

        public PfnSetBlobFuncANDROID
        (
            SetBlobFuncANDROID proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnSetBlobFuncANDROID From(SetBlobFuncANDROID proc) => new PfnSetBlobFuncANDROID(proc);

        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnSetBlobFuncANDROID pfn) => (nint) pfn.Handle;

        public static explicit operator PfnSetBlobFuncANDROID(nint pfn)
            => new PfnSetBlobFuncANDROID((delegate* unmanaged[Cdecl]<void*, int, void*, int, void>) pfn);

        public static implicit operator PfnSetBlobFuncANDROID(SetBlobFuncANDROID proc) => new PfnSetBlobFuncANDROID(proc);

        public static explicit operator SetBlobFuncANDROID(PfnSetBlobFuncANDROID pfn)
            => SilkMarshal.PtrToDelegate<SetBlobFuncANDROID>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int, void*, int, void>
            (PfnSetBlobFuncANDROID pfn) => pfn.Handle;

        public static implicit operator PfnSetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void> ptr) => new(ptr);
    }

    /// <summary>
    /// The managed form of an <c>EGLSetBlobFuncANDROID</c> callback.
    /// </summary>
    /// <param name="key">The key of the blob to write.</param>
    /// <param name="keySize">The size of <paramref name="key" /> in bytes.</param>
    /// <param name="value">The blob to store.</param>
    /// <param name="valueSize">The size of <paramref name="value" /> in bytes.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SetBlobFuncANDROID
    (
        void* key,
        int keySize,
        void* value,
        int valueSize
    );
}
