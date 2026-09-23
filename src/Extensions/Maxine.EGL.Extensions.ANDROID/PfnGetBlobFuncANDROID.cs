// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Maxine.EGL.Extensions.ANDROID
{
    /// <summary>
    /// A function pointer for <c>EGLGetBlobFuncANDROID</c>, passed to <c>eglSetBlobCacheFuncsANDROID</c>.
    /// </summary>
    public readonly unsafe struct PfnGetBlobFuncANDROID : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, int, void*, int, int> Handle =>
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, int>) _handle;

        public PfnGetBlobFuncANDROID
        (
            delegate* unmanaged[Cdecl]<void*, int, void*, int, int> ptr
        ) => _handle = ptr;

        public PfnGetBlobFuncANDROID
        (
            GetBlobFuncANDROID proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnGetBlobFuncANDROID From(GetBlobFuncANDROID proc) => new PfnGetBlobFuncANDROID(proc);

        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnGetBlobFuncANDROID pfn) => (nint) pfn.Handle;

        public static explicit operator PfnGetBlobFuncANDROID(nint pfn)
            => new PfnGetBlobFuncANDROID((delegate* unmanaged[Cdecl]<void*, int, void*, int, int>) pfn);

        public static implicit operator PfnGetBlobFuncANDROID(GetBlobFuncANDROID proc) => new PfnGetBlobFuncANDROID(proc);

        public static explicit operator GetBlobFuncANDROID(PfnGetBlobFuncANDROID pfn)
            => SilkMarshal.PtrToDelegate<GetBlobFuncANDROID>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int, void*, int, int>
            (PfnGetBlobFuncANDROID pfn) => pfn.Handle;

        public static implicit operator PfnGetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, int> ptr) => new(ptr);
    }

    /// <summary>
    /// The managed form of an <c>EGLGetBlobFuncANDROID</c> callback.
    /// </summary>
    /// <param name="key">The key of the blob to read.</param>
    /// <param name="keySize">The size of <paramref name="key" /> in bytes.</param>
    /// <param name="value">The buffer the blob is written to.</param>
    /// <param name="valueSize">The size of <paramref name="value" /> in bytes.</param>
    /// <returns>The number of bytes written to <paramref name="value" />, or 0 if the blob is absent.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int GetBlobFuncANDROID
    (
        void* key,
        int keySize,
        void* value,
        int valueSize
    );
}
