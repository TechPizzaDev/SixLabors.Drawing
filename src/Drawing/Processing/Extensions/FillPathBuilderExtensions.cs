// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the filling of polygons with various brushes to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class FillPathBuilderExtensions
    {
        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The graphics options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="path">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathBuilderExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(
            this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, Action<PathBuilder> path)
            where TPixel : unmanaged, IPixel<TPixel>
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            Action<PathBuilder> path)
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathBuilderExtensions.cs
        {
            var pb = new PathBuilder();
            path(pb);

            return source.Fill(options, brush, pb.Build());
        }

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathBuilderExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(
            this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, Action<PathBuilder> path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(GraphicsOptions.Default, brush, path);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            IBrush brush,
            Action<PathBuilder> path) =>
            source.Fill(GraphicsOptions.Default, brush, path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathBuilderExtensions.cs

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathBuilderExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(
            this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, Action<PathBuilder> path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(options, new SolidBrush<TPixel>(color), path);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            Action<PathBuilder> path) =>
            source.Fill(options, new SolidBrush(color), path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathBuilderExtensions.cs

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="path">The path.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathBuilderExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(
            this IImageProcessingContext<TPixel> source, TPixel color, Action<PathBuilder> path)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(new SolidBrush<TPixel>(color), path);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            Color color,
            Action<PathBuilder> path) =>
            source.Fill(new SolidBrush(color), path);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathBuilderExtensions.cs
    }
}