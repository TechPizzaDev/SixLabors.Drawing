// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Primitives
{
    /// <summary>
    /// Represents a region of an image.
    /// </summary>
    public abstract class Region : IDisposable
    {
        /// <summary>
        /// Gets if this region is disposed.
        /// </summary>
        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Gets the maximum number of intersections to could be returned.
        /// </summary>
        public abstract int MaxIntersections { get; }

        /// <summary>
        /// Gets the bounding box that entirely surrounds this region.
        /// </summary>
        /// <remarks>
        /// This should always contains all possible points returned from <see cref="Scan"/>.
        /// </remarks>
        public abstract Rectangle Bounds { get; }

        /// <summary>
        /// Scans the X axis for intersections at the Y axis position.
        /// </summary>
        /// <param name="y">The position along the y axis to find intersections.</param>
        /// <param name="buffer">The buffer.</param>
        /// <param name="configuration">A <see cref="Configuration"/> instance in the context of the caller.</param>
        /// <returns>The number of intersections found.</returns>
        public abstract int Scan(float y, Span<float> buffer, Configuration configuration);

        /// <summary>
        /// Internal dispose implemented by inhereting classes.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.IsDisposed)
                this.IsDisposed = true;
        }

        /// <summary>
        /// Finalizer for this region.
        /// </summary>
        ~Region()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Disposes this region.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}