// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Primitives;
using SixLabors.ImageSharp.Processing.Processors.Drawing;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the filling of regions with various brushes to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class FillRegionExtensions
    {
        /// <summary>
        /// Flood fills the image with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The details how to fill the region of interest.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(GraphicsOptions.Default, brush);
=======
        public static IImageProcessingContext Fill(this IImageProcessingContext source, IBrush brush) =>
            source.Fill(GraphicsOptions.Default, brush);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with the specified color.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(new SolidBrush<TPixel>(color));
=======
        public static IImageProcessingContext Fill(this IImageProcessingContext source, Color color) =>
            source.Fill(new SolidBrush(color));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with in the region with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="region">The region.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, Region region)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(GraphicsOptions.Default, brush, region);
=======
        public static IImageProcessingContext Fill(this IImageProcessingContext source, IBrush brush, Region region) =>
            source.Fill(GraphicsOptions.Default, brush, region);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with in the region with the specified color.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="region">The region.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, Region region)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(options, new SolidBrush<TPixel>(color), region);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            Region region) =>
            source.Fill(options, new SolidBrush(color), region);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with in the region with the specified color.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="region">The region.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, Region region)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(new SolidBrush<TPixel>(color), region);
=======
        public static IImageProcessingContext Fill(this IImageProcessingContext source, Color color, Region region) =>
            source.Fill(new SolidBrush(color), region);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with in the region with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The graphics options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="region">The region.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, Region region)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.ApplyProcessor(new FillRegionProcessor<TPixel>(brush, region, options));
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            Region region) =>
            source.ApplyProcessor(new FillRegionProcessor(brush, region, options));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs

        /// <summary>
        /// Flood fills the image with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The graphics options.</param>
        /// <param name="brush">The details how to fill the region of interest.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillRegionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.ApplyProcessor(new FillProcessor<TPixel>(brush, options));
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush) =>
            source.ApplyProcessor(new FillProcessor(brush, options));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillRegionExtensions.cs
    }
}