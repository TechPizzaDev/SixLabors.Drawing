// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of collections of polygon outlines to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawPathCollectionExtensions
    {
        /// <summary>
        /// Draws the outline of the polygon with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IPen<TPixel> pen, IPathCollection paths)
           where TPixel : unmanaged, IPixel<TPixel>
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IPen pen,
            IPathCollection paths)
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs
        {
            foreach (IPath path in paths)
            {
                source.Draw(options, pen, path);
            }

            return source;
        }

        /// <summary>
        /// Draws the outline of the polygon with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IPen<TPixel> pen, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(GraphicsOptions.Default, pen, paths);
=======
        public static IImageProcessingContext
            Draw(this IImageProcessingContext source, IPen pen, IPathCollection paths) =>
            source.Draw(GraphicsOptions.Default, pen, paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="paths">The shapes.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, float thickness, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new Pen<TPixel>(brush, thickness), paths);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            float thickness,
            IPathCollection paths) =>
            source.Draw(options, new Pen(brush, thickness), paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, float thickness, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new Pen<TPixel>(brush, thickness), paths);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            IBrush brush,
            float thickness,
            IPathCollection paths) =>
            source.Draw(new Pen(brush, thickness), paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, float thickness, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new SolidBrush<TPixel>(color), thickness, paths);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            float thickness,
            IPathCollection paths) =>
            source.Draw(options, new SolidBrush(color), thickness, paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs

        /// <summary>
        /// Draws the outline of the polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, float thickness, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new SolidBrush<TPixel>(color), thickness, paths);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            Color color,
            float thickness,
            IPathCollection paths) =>
            source.Draw(new SolidBrush(color), thickness, paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPathCollectionExtensions.cs
    }
}