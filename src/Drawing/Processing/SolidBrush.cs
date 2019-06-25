// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Buffers;

using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Memory;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Memory;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Provides an implementation of a solid brush for painting solid color areas.
    /// </summary>
    public class SolidBrush : IBrush
    {
        /// <summary>
        /// The color to paint.
        /// </summary>
        private readonly Color color;

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidBrush"/> class.
        /// </summary>
        /// <param name="color">The color.</param>
        public SolidBrush(Color color)
        {
            this.color = color;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public Color Color => this.color;

        /// <inheritdoc />
        public BrushApplicator<TPixel> CreateApplicator<TPixel>(
            ImageFrame<TPixel> source, RectangleF region, GraphicsOptions options)
            where TPixel : unmanaged, IPixel<TPixel>
        {
            return new SolidBrushApplicator<TPixel>(source, this.color.ToPixel<TPixel>(), options);
        }

        /// <summary>
        /// The solid brush applicator.
        /// </summary>
        private class SolidBrushApplicator<TPixel> : BrushApplicator<TPixel>
            where TPixel : unmanaged, IPixel<TPixel>
        {
            private const int MaxColorBufferWidth = 2048;
            private const int MaxScanlineWidth = 2048;

            private TPixel _color;
            private int _width;

            /// <summary>
            /// Initializes a new instance of the <see cref="SolidBrushApplicator{TPixel}"/> class.
            /// </summary>
            /// <param name="source">The source image.</param>
            /// <param name="color">The color.</param>
            /// <param name="options">The options</param>
            public SolidBrushApplicator(ImageFrame<TPixel> source, TPixel color, GraphicsOptions options)
                : base(source, options)
            {
                this._color = color;
                this._width = source.Width;

                if (source.Width >= MaxColorBufferWidth)
                {
                    this.Colors = source.MemoryAllocator.Allocate<TPixel>(this._width);
                    this.Colors.GetSpan().Fill(this._color);
                }
            }

            /// <summary>
            /// Gets the colors.
            /// </summary>
            protected IMemoryOwner<TPixel> Colors { get; }

            /// <summary>
            /// Gets the color for a single pixel.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <returns>
            /// The color
            /// </returns>
            internal override TPixel this[int x, int y] => this.Colors.GetSpan()[x];

            /// <inheritdoc />
            public override void Dispose()
            {
                this.Colors.Dispose();
            }

            /// <inheritdoc />
            internal override void Apply(Span<float> scanline, int x, int y)
            {
                Span<TPixel> destinationRow = this.Target.GetPixelRowSpan(y).Slice(x);

                // constrain the spans to each other
                if (destinationRow.Length > scanline.Length)
                {
                    destinationRow = destinationRow.Slice(0, scanline.Length);
                }
                else
                {
                    scanline = scanline.Slice(0, destinationRow.Length);
                }

                MemoryAllocator memoryAllocator = this.Target.MemoryAllocator;
                Configuration configuration = this.Target.Configuration;

                Span<TPixel> colorBuffer = stackalloc TPixel[this._width < MaxColorBufferWidth ? this._width : 0];
                colorBuffer.Fill(this._color);

                if (this.Options.BlendPercentage == 1f)
                {
                    this.Blender.Blend(configuration, destinationRow, destinationRow, this.Colors.GetSpan(), scanline);
                }
                else
                {
                    void Body(Span<float> amount, Span<float> scan, Span<TPixel> dstRow, Span<TPixel> colors)
                    {
                        float percentage = this.Options.BlendPercentage;
                        for (int i = 0; i < scan.Length; i++)
                            amount[i] = scan[i] * percentage;

                        if (this._width >= MaxColorBufferWidth)
                        {
                            this.Blender.Blend(
                                this.Target.Configuration, dstRow, dstRow, this.Colors.GetSpan(), amount);
                        }
                        else
                        {
                            this.Blender.Blend(
                                this.Target.Configuration, dstRow, dstRow, colors, amount);
                        }
                    }

                    if (scanline.Length >= MaxScanlineWidth)
                    {
                        using (IMemoryOwner<float> amountBuffer = memoryAllocator.Allocate<float>(scanline.Length))
                        {
                            Span<float> amountSpan = amountBuffer.GetSpan();
                            Body(amountSpan, scanline, destinationRow, colorBuffer);
                        }
                    }
                    else
                    {
                        Span<float> amountBuffer = stackalloc float[scanline.Length];
                        Body(amountBuffer, scanline, destinationRow, colorBuffer);
                    }

                    using (IMemoryOwner<float> amountBuffer = memoryAllocator.Allocate<float>(scanline.Length))
                    {
                        Span<float> amountSpan = amountBuffer.GetSpan();

                        for (int i = 0; i < scanline.Length; i++)
                        {
                            amountSpan[i] = scanline[i] * this.Options.BlendPercentage;
                        }

                        this.Blender.Blend(
                            configuration,
                            destinationRow,
                            destinationRow,
                            this.Colors.GetSpan(),
                            amountSpan);
                    }
                }
            }
        }
    }
}