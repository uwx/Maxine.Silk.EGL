// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Maxine.EGL.Extensions.HI
{
    /// <summary>
    /// Describes a native pixmap, as expected by <c>eglCreatePixmapSurfaceHI</c>.
    /// </summary>
    public unsafe struct ClientPixmapHI
    {
        /// <summary>
        /// The native pixmap's image data.
        /// </summary>
        public void* PData;

        /// <summary>
        /// The pixel width of the pixmap.
        /// </summary>
        public int Width;

        /// <summary>
        /// The pixel height of the pixmap.
        /// </summary>
        public int Height;

        /// <summary>
        /// The number of bytes between consecutive rows of the pixmap.
        /// </summary>
        public int Stride;

        /// <summary>
        /// Creates a new <see cref="ClientPixmapHI" />.
        /// </summary>
        /// <param name="pData">The native pixmap's image data.</param>
        /// <param name="width">The pixel width of the pixmap.</param>
        /// <param name="height">The pixel height of the pixmap.</param>
        /// <param name="stride">The number of bytes between consecutive rows of the pixmap.</param>
        public ClientPixmapHI(void* pData, int width, int height, int stride)
        {
            PData = pData;
            Width = width;
            Height = height;
            Stride = stride;
        }
    }
}
