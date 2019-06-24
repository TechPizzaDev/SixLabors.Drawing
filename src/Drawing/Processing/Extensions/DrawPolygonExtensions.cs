// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of closed linear polygons to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawPolygonExtensions
    {
        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new Pen<TPixel>(brush, thickness), new Polygon(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            float thickness,
            params PointF[] points) =>
            source.Draw(options, new Pen(brush, thickness), new Polygon(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs

        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new Pen<TPixel>(brush, thickness), new Polygon(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            IBrush brush,
            float thickness,
            params PointF[] points) =>
            source.Draw(new Pen(brush, thickness), new Polygon(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs

        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.DrawPolygon(new SolidBrush<TPixel>(color), thickness, points);
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            Color color,
            float thickness,
            params PointF[] points) =>
            source.DrawPolygon(new SolidBrush(color), thickness, points);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs

        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided brush at the provided thickness.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.DrawPolygon(options, new SolidBrush<TPixel>(color), thickness, points);
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            float thickness,
            params PointF[] points) =>
            source.DrawPolygon(options, new SolidBrush(color), thickness, points);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs

        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided Pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, IPen<TPixel> pen, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(GraphicsOptions.Default, pen, new Polygon(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            IPen pen,
            params PointF[] points) =>
            source.Draw(GraphicsOptions.Default, pen, new Polygon(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs

        /// <summary>
        /// Draws the provided Points as a closed Linear Polygon with the provided Pen.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawPolygonExtensions.cs
        public static IImageProcessingContext<TPixel> DrawPolygon<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IPen<TPixel> pen, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, pen, new Polygon(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawPolygon(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IPen pen,
            params PointF[] points) =>
            source.Draw(options, pen, new Polygon(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawPolygonExtensions.cs
    }
}