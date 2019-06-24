// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of rectangles to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawRectangleExtensions
    {
        /// <summary>
        /// Draws the outline of the rectangle with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IPen<TPixel> pen, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, pen, new RectangularPolygon(shape.X, shape.Y, shape.Width, shape.Height));
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IPen pen,
            RectangleF shape) =>
            source.Draw(options, pen, new RectangularPolygon(shape.X, shape.Y, shape.Width, shape.Height));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs

        /// <summary>
        /// Draws the outline of the rectangle with the provided pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IPen<TPixel> pen, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(GraphicsOptions.Default, pen, shape);
=======
        public static IImageProcessingContext Draw(this IImageProcessingContext source, IPen pen, RectangleF shape) =>
            source.Draw(GraphicsOptions.Default, pen, shape);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs

        /// <summary>
        /// Draws the outline of the rectangle with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, float thickness, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new Pen<TPixel>(brush, thickness), shape);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            float thickness,
            RectangleF shape) =>
            source.Draw(options, new Pen(brush, thickness), shape);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs

        /// <summary>
        /// Draws the outline of the rectangle with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, float thickness, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new Pen<TPixel>(brush, thickness), shape);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            IBrush brush,
            float thickness,
            RectangleF shape) =>
            source.Draw(new Pen(brush, thickness), shape);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs

        /// <summary>
        /// Draws the outline of the rectangle with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, float thickness, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new SolidBrush<TPixel>(color), thickness, shape);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            float thickness,
            RectangleF shape) =>
            source.Draw(options, new SolidBrush(color), thickness, shape);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs

        /// <summary>
        /// Draws the outline of the rectangle with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="shape">The shape.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawRectangleExtensions.cs
        public static IImageProcessingContext<TPixel> Draw<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, float thickness, RectangleF shape)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new SolidBrush<TPixel>(color), thickness, shape);
=======
        public static IImageProcessingContext Draw(
            this IImageProcessingContext source,
            Color color,
            float thickness,
            RectangleF shape) =>
            source.Draw(new SolidBrush(color), thickness, shape);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawRectangleExtensions.cs
    }
}