// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Maxine.EGL
{
    /// <summary>
    /// A function pointer for <c>EGLDEBUGPROCKHR</c>, passed to <c>eglDebugMessageControlKHR</c>.
    /// </summary>
    public readonly unsafe struct PfnDebugProcKhr : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> Handle =>
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>) _handle;

        public PfnDebugProcKhr
        (
            delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> ptr
        ) => _handle = ptr;

        public PfnDebugProcKhr
        (
            DebugProcKhr proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDebugProcKhr From(DebugProcKhr proc) => new PfnDebugProcKhr(proc);

        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDebugProcKhr pfn) => (nint) pfn.Handle;

        public static explicit operator PfnDebugProcKhr(nint pfn)
            => new PfnDebugProcKhr((delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>) pfn);

        public static implicit operator PfnDebugProcKhr(DebugProcKhr proc) => new PfnDebugProcKhr(proc);

        public static explicit operator DebugProcKhr(PfnDebugProcKhr pfn)
            => SilkMarshal.PtrToDelegate<DebugProcKhr>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>
            (PfnDebugProcKhr pfn) => pfn.Handle;

        public static implicit operator PfnDebugProcKhr
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> ptr) => new(ptr);
    }

    /// <summary>
    /// The managed form of an <c>EGLDEBUGPROCKHR</c> callback.
    /// </summary>
    /// <param name="error">The <see cref="EGLEnum" /> error that triggered this message.</param>
    /// <param name="command">The command that generated this message.</param>
    /// <param name="messageType">The type of this message.</param>
    /// <param name="threadLabel">The label associated with the current thread.</param>
    /// <param name="objectLabel">The label associated with the object referenced by <paramref name="command" />.</param>
    /// <param name="message">The message text.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int DebugProcKhr
    (
        EGLEnum error,
        byte* command,
        int messageType,
        nint threadLabel,
        nint objectLabel,
        byte* message
    );
}
