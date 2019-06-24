// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Primitives;
<<<<<<< HEAD
using SixLabors.ImageSharp.Utils;
using SixLabors.Primitives;
=======
using SixLabors.Memory;
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

namespace SixLabors.ImageSharp.Processing.Processors.Drawing
{
    /// <summary>
    /// Defines a processor to fill <see cref="Image"/> pixels withing a given <see cref="Region"/>
    /// with the given <see cref="IBrush"/> and blending defined by the given <see cref="GraphicsOptions"/>.
    /// </summary>
<<<<<<< HEAD
    /// <typeparam name="TPixel">The type of the color.</typeparam>
    /// <seealso cref="ImageProcessor{TPixel}" />
    internal class FillRegionProcessor<TPixel> : ImageProcessor<TPixel>
        where TPixel : unmanaged, IPixel<TPixel>
    {
        //private const float AntiAliasFactor = 1f;
        //private const int DrawPadding = 1;

=======
    public class FillRegionProcessor : IImageProcessor
    {
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
        /// <summary>
        /// Initializes a new instance of the <see cref="FillRegionProcessor" /> class.
        /// </summary>
        /// <param name="brush">The details how to fill the region of interest.</param>
        /// <param name="region">The region of interest to be filled.</param>
        /// <param name="options">The configuration options.</param>
        public FillRegionProcessor(IBrush brush, Region region, GraphicsOptions options)
        {
            this.Region = region;
            this.Brush = brush;
            this.Options = options;
        }

        /// <summary>
        /// Gets the <see cref="IBrush"/> used for filling the destination image.
        /// </summary>
        public IBrush Brush { get; }

        /// <summary>
        /// Gets the region that this processor applies to.
        /// </summary>
        public Region Region { get; }

        /// <summary>
        /// Gets the <see cref="GraphicsOptions"/> defining how to blend the brush pixels over the image pixels.
        /// </summary>
        public GraphicsOptions Options { get; }

<<<<<<< HEAD
        /// <inheritdoc/>
        protected override void OnFrameApply(ImageFrame<TPixel> source, Rectangle sourceRectangle, Configuration configuration)
        {
            Region region = this.Region;
            Rectangle rect = region.Bounds;

            // Align start/end positions.
            int minX = Math.Max(0, rect.Left);
            int maxX = Math.Min(source.Width, rect.Right);
            int minY = Math.Max(0, rect.Top);
            int maxY = Math.Min(source.Height, rect.Bottom);
            if (minX >= maxX)
                return; // no effect inside image;
            
            if (minY >= maxY)
                return; // no effect inside image;

            int scanlineWidth = maxX - minX;
            int maxIntersections = region.MaxIntersections;
            float subpixelCount = 4;

            // we need to offset the pixel grid to account for when we outline a path.
            // basically if the line is [1,2] => [3,2] then when outlining at 1 we end up with a region of [0.5,1.5],[1.5, 1.5],[3.5,2.5],[2.5,2.5]
            // and this can cause missed fills when not using anti-aliasing.so we offset the pixel grid by 0.5 in the x & y direction thus causing the#
            // region to align with the pixel grid.
            float offset = 0.5f;
            if (this.Options.AntiAlias)
            {
                 // we are anti-aliasing skip offsetting as real anti-aliasing should take care of offset.
                offset = 0f;

                subpixelCount = this.Options.AntiAliasSubpixelDepth;
                if (subpixelCount < 4)
                    subpixelCount = 4;
            }

            void Body(BrushApplicator<TPixel> brush, Span<float> buffer, Span<float> scanline)
            {
                    bool isSolidBrushWithoutBlending = this.IsSolidBrushWithoutBlending(out SolidBrush<TPixel> solidBrush);
                    bool scanlineDirty = true;
                    float subpixelFraction = 1f / subpixelCount;
                    float subpixelFractionPoint = subpixelFraction / subpixelCount;

                    for (int y = minY; y < maxY; y++)
                    {
                        if (scanlineDirty)
                        {
                            scanline.Clear();
                            scanlineDirty = false;
                        }

                        float yPlusOne = y + 1;
                        for (float subPixel = (float)y; subPixel < yPlusOne; subPixel += subpixelFraction)
                        {
                            int pointsFound = region.Scan(subPixel + offset, buffer, configuration);
                            if (pointsFound == 0)
                                // nothing on this line, skip
                                continue;

                        QuickSort.Sort(buffer.Slice(0, pointsFound));

                        for (int point = 0; point < pointsFound; point += 2)
                        {
                            // points will be paired up
                            float scanStart = buffer[point] - minX;
                            float scanEnd = buffer[point + 1] - minX;
                            int startX = (int)MathF.Floor(scanStart + offset);
                            int endX = (int)MathF.Floor(scanEnd + offset);

                            if (startX >= 0 && startX < scanline.Length)
                            {
                                for (float x = scanStart; x < startX + 1; x += subpixelFraction)
                                {
                                    scanline[startX] += subpixelFractionPoint;
                                    scanlineDirty = true;
                                }
                            }

                            if (endX >= 0 && endX < scanline.Length)
                            {
                                for (float x = endX; x < scanEnd; x += subpixelFraction)
                                {
                                    scanline[endX] += subpixelFractionPoint;
                                    scanlineDirty = true;
                                }
                            }

                            int nextX = startX + 1;
                            endX = Math.Min(endX, scanline.Length); // reduce to end to the right edge
                            nextX = Math.Max(nextX, 0);
                            for (int x = nextX; x < endX; x++)
                            {
                                scanline[x] += subpixelFraction;
                                scanlineDirty = true;
                            }
                        }
                    }

                        if (scanlineDirty)
                        {
                            if (!this.Options.AntiAlias)
                            {
                                bool hasOnes = false;
                                bool hasZeros = false;
                                for (int x = 0; x < scanlineWidth; x++)
                                {
                                    if (scanline[x] >= 0.5)
                                    {
                                        scanline[x] = 1;
                                        hasOnes = true;
                                    }
                                    else
                                    {
                                        scanline[x] = 0;
                                        hasZeros = true;
                                    }
                                }

                            if (isSolidBrushWithoutBlending && hasOnes != hasZeros)
                            {
                                if (hasOnes)
                                    source.GetPixelRowSpan(y).Slice(minX, scanlineWidth).Fill(solidBrush.Color);
                                continue;
                            }
                        }

                        brush.Apply(scanline, minX, y);
                    }
                }
            }

            using (BrushApplicator<TPixel> applicator = this.Brush.CreateApplicator(source, rect, this.Options))
            {
                const int maxIntersectionBuffer = 512;
                const int maxScanlineBuffer = 2048;

                IMemoryOwner<float> bBuffer = null;
                IMemoryOwner<float> bScanline = null;
                Span<float> buff = stackalloc float[maxIntersections < maxIntersectionBuffer ? maxIntersections : 0];
                Span<float> scan = stackalloc float[scanlineWidth < maxScanlineBuffer ? scanlineWidth : 0];

                try
                {
                    if (maxIntersections >= maxIntersectionBuffer)
                    {
                        bBuffer = source.MemoryAllocator.Allocate<float>(maxIntersections);
                        buff = bBuffer.AsSpan();
                    }

                    if (scanlineWidth >= maxScanlineBuffer)
                    {
                        bScanline = source.MemoryAllocator.Allocate<float>(scanlineWidth);
                        scan = bScanline.AsSpan();
                    }

                    Body(applicator, buff, scan);
                }
                finally
                {
                    bBuffer?.Dispose();
                    bScanline?.Dispose();
                }
            }
        }

        private bool IsSolidBrushWithoutBlending(out SolidBrush<TPixel> solidBrush)
        {
            solidBrush = this.Brush as SolidBrush<TPixel>;
            if (solidBrush == null)
                return false;

            return this.Options.IsOpaqueColorWithoutBlending(solidBrush.Color);
=======
        /// <inheritdoc />
        public IImageProcessor<TPixel> CreatePixelSpecificProcessor<TPixel>()
            where TPixel : struct, IPixel<TPixel>
        {
            return new FillRegionProcessor<TPixel>(this);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
        }
    }
}