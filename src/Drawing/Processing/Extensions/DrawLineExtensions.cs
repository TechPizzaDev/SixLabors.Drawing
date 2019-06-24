// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of lines to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawLineExtensions
    {
        /// <summary>
        /// Draws the provided Points as an open Linear path at the provided thickness with the supplied brush
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, new Pen<TPixel>(brush, thickness), new Path(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            float thickness,
            params PointF[] points) =>
            source.Draw(options, new Pen(brush, thickness), new Path(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs

        /// <summary>
        /// Draws the provided Points as an open Linear path at the provided thickness with the supplied brush
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(new Pen<TPixel>(brush, thickness), new Path(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            IBrush brush,
            float thickness,
            params PointF[] points) =>
            source.Draw(new Pen(brush, thickness), new Path(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs

        /// <summary>
        /// Draws the provided Points as an open Linear path at the provided thickness with the supplied brush
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.DrawLines(new SolidBrush<TPixel>(color), thickness, points);
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            Color color,
            float thickness,
            params PointF[] points) =>
            source.DrawLines(new SolidBrush(color), thickness, points);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs

        /// <summary>
        /// Draws the provided Points as an open Linear path at the provided thickness with the supplied brush
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="thickness">The thickness.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, float thickness, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.DrawLines(options, new SolidBrush<TPixel>(color), thickness, points);
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            float thickness,
            params PointF[] points) =>
            source.DrawLines(options, new SolidBrush(color), thickness, points);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs

        /// <summary>
        /// Draws the provided Points as an open Linear path with the supplied pen
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, IPen<TPixel> pen, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(options, pen, new Path(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IPen pen,
            params PointF[] points) =>
            source.Draw(options, pen, new Path(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs

        /// <summary>
        /// Draws the provided Points as an open Linear path with the supplied pen
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="pen">The pen.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/DrawLineExtensions.cs
        public static IImageProcessingContext<TPixel> DrawLines<TPixel>(this IImageProcessingContext<TPixel> source, IPen<TPixel> pen, params PointF[] points)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Draw(pen, new Path(new LinearLineSegment(points)));
=======
        public static IImageProcessingContext DrawLines(
            this IImageProcessingContext source,
            IPen pen,
            params PointF[] points) =>
            source.Draw(pen, new Path(new LinearLineSegment(points)));
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/DrawLineExtensions.cs
    }
}