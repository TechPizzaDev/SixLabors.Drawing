// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

<<<<<<< HEAD
using System;
using System.Buffers;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Memory;
using SixLabors.ImageSharp.ParallelUtils;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
=======
using System.Threading.Tasks;

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Memory;
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

namespace SixLabors.ImageSharp.Processing.Processors.Drawing
{
    /// <summary>
    /// Defines a processor to fill an <see cref="Image"/> with the given <see cref="IBrush"/>
    /// using blending defined by the given <see cref="GraphicsOptions"/>.
    /// </summary>
<<<<<<< HEAD
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    internal class FillProcessor<TPixel> : ImageProcessor<TPixel>
        where TPixel : unmanaged, IPixel<TPixel>
=======
    public class FillProcessor : IImageProcessor
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FillProcessor"/> class.
        /// </summary>
        /// <param name="brush">The brush to use for filling.</param>
        /// <param name="options">The <see cref="GraphicsOptions"/> defining how to blend the brush pixels over the image pixels.</param>
        public FillProcessor(IBrush brush, GraphicsOptions options)
        {
            this.Brush = brush;
            this.Options = options;
        }

<<<<<<< HEAD
        /// <inheritdoc/>
        protected override void OnFrameApply(
            ImageFrame<TPixel> source, Rectangle sourceRectangle, Configuration configuration)
        {
            int startX = sourceRectangle.X;
            int endX = sourceRectangle.Right;
            int startY = sourceRectangle.Y;
            int endY = sourceRectangle.Bottom;

            // Align start/end positions.
            int minX = Math.Max(0, startX);
            int maxX = Math.Min(source.Width, endX);
            int minY = Math.Max(0, startY);
            int maxY = Math.Min(source.Height, endY);

            int width = maxX - minX;

            var workingRect = Rectangle.FromLTRB(minX, minY, maxX, maxY);

            // If there's no reason for blending, then avoid it.
            if (this.IsSolidBrushWithoutBlending(out SolidBrush<TPixel> solidBrush))
            {
                ParallelExecutionSettings parallelSettings = 
                    configuration.GetParallelSettings().MultiplyMinimumPixelsPerTask(4);

                ParallelHelper.IterateRows(
                    workingRect,
                    parallelSettings,
                    rows =>
                    {
                        for (int y = rows.Min; y < rows.Max; y++)
                        {
                            source.GetPixelRowSpan(y).Slice(minX, width).Fill(solidBrush.Color);
                        }
                    });
            }
            else
            {
                // Reset offset if necessary.
                if (minX > 0)
                    startX = 0;

                if (minY > 0)
                    startY = 0;

                using (IMemoryOwner<float> amount = source.MemoryAllocator.Allocate<float>(width))
                using (BrushApplicator<TPixel> applicator = this.brush.CreateApplicator(
                    source, sourceRectangle, this.options))
                {
                    amount.AsSpan().Fill(1f);

                    ParallelHelper.IterateRows(
                        workingRect,
                        configuration,
                        rows =>
                        {
                            Span<float> span = amount.AsSpan();
                            for (int y = rows.Min; y < rows.Max; y++)
                            {
                                int offsetY = y - startY;
                                int offsetX = minX - startX;
                                applicator.Apply(span, offsetX, offsetY);
                            }
                        });
                }
            }
        }
=======
        /// <summary>
        /// Gets the <see cref="IBrush"/> used for filling the destination image.
        /// </summary>
        public IBrush Brush { get; }

        /// <summary>
        /// Gets the <see cref="GraphicsOptions"/> defining how to blend the brush pixels over the image pixels.
        /// </summary>
        public GraphicsOptions Options { get; }
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <inheritdoc />
        public IImageProcessor<TPixel> CreatePixelSpecificProcessor<TPixel>()
            where TPixel : struct, IPixel<TPixel>
        {
<<<<<<< HEAD
            solidBrush = this.brush as SolidBrush<TPixel>;
            if (solidBrush == null)
                return false;

            return this.options.IsOpaqueColorWithoutBlending(solidBrush.Color);
=======
            return new FillProcessor<TPixel>(this);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
        }
    }
}