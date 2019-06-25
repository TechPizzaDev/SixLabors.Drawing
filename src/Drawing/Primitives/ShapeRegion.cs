// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Buffers;
using SixLabors.ImageSharp.Memory;
using SixLabors.Primitives;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Primitives
{
    /// <summary>
    /// A mapping between a <see cref="IPath"/> and a region.
    /// </summary>
    internal class ShapeRegion : Region
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeRegion"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public ShapeRegion(IPath shape)
        {
            this.Shape = shape.AsClosedPath();
            int left = (int)MathF.Floor(shape.Bounds.Left);
            int top = (int)MathF.Floor(shape.Bounds.Top);
            int right = (int)MathF.Ceiling(shape.Bounds.Right);
            int bottom = (int)MathF.Ceiling(shape.Bounds.Bottom);
            this.Bounds = Rectangle.FromLTRB(left, top, right, bottom);
        }

        /// <summary>
        /// Gets the fillable shape.
        /// </summary>
        public IPath Shape { get; private set; }

        /// <inheritdoc/>
        public override int MaxIntersections
        {
            get
            {
                if (this.IsDisposed)
                    throw new ObjectDisposedException(nameof(ShapeRegion));
                return this.Shape.MaxIntersections;
            }
        }

        /// <inheritdoc/>
        public override Rectangle Bounds { get; }

        /// <inheritdoc/>
        public override int Scan(float y, Span<float> buffer, Configuration configuration)
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(ShapeRegion));

            var start = new PointF(this.Bounds.Left - 1, y);
            var end = new PointF(this.Bounds.Right + 1, y);

            if (buffer.Length > 512)
            {
                using (IMemoryOwner<PointF> tempBuffer = configuration.MemoryAllocator.Allocate<PointF>(buffer.Length))
                {
                    Span<PointF> innerBuffer = tempBuffer.GetSpan();
                    return this.Scan(start, end, buffer, innerBuffer);
                }
            }
            else
            {
                Span<PointF> innerBuffer = stackalloc PointF[buffer.Length];
                return this.Scan(start, end, buffer, innerBuffer);
            }
        }

        private int Scan(PointF start, PointF end, Span<float> output, Span<PointF> buffer)
        {
            if (IsDisposed)
                throw new ObjectDisposedException(nameof(ShapeRegion));

            int count = this.Shape.FindIntersections(start, end, buffer);
            for (int i = 0; i < count; i++)
                output[i] = buffer[i].X;
            return count;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Shape.Dispose();
                Shape = null;
            }
            base.Dispose(disposing);
        }
    }
}