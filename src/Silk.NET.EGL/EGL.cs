using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL
{
    public partial class EGL
    {
        public static unsafe EGL GetApi()
        {
            var ctx = new MultiNativeContext(null, CreateDefaultContext(new EGLLibraryNameContainer().GetLibraryNames()));
            var ret = new EGL(ctx);
            ctx.Contexts[0] = new LamdaNativeContext
            (
                (string proc, out nint pfn) =>
                    (pfn = proc != "eglGetProcAddress" ? (nint) ret.GetProcAddress(proc) : 0) != 0
            );
            return ret;
        }

#if NET5_0_OR_GREATER
        public bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(out T ext)
#else
        public bool TryGetExtension<T>(out T ext)
#endif
            where T : NativeExtension<EGL>
        {
            ext = IsExtensionPresent(GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance(typeof(T), Context)
                : null;
            return ext is not null;
        }

        private List<string> _extensions;

        /// <summary>
        /// Determines whether a particular EGL extension is present on the machine's driver.
        /// </summary>
        /// <param name="extension">
        /// Standard identifier for the extension. The <c>EGL_</c> prefix is optional.
        /// </param>
        /// <returns>
        /// <c>true</c> if the extension is present, otherwise <c>false</c>.
        /// </returns>
        public override unsafe bool IsExtensionPresent(string extension)
        {
            // EGL exposes its client extensions through eglQueryString with no display bound, which is legal
            // before eglInitialize and does not require a connection to a display server.
            _extensions ??= SilkMarshal.PtrToString((nint) QueryString((nint) EGLEnum.NoDisplay, (int) EGLEnum.Extensions))
                ?.Split(' ')
                .ToList() ?? new List<string>();

            return _extensions.Contains
                (extension.StartsWith("EGL_") ? extension : $"EGL_{extension}");
        }
    }
}
