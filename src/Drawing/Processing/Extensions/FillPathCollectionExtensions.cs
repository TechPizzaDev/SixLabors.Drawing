// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Shapes;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the filling of collections of polygon outlines to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class FillPathCollectionExtensions
    {
        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The graphics options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="paths">The shapes.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(
            this IImageProcessingContext<TPixel> source, GraphicsOptions options, IBrush<TPixel> brush, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            IBrush brush,
            IPathCollection paths)
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathCollectionExtensions.cs
        {
            if (paths is IList<IPath> list)
            {
                int c = list.Count;
                for (int i = 0; i < c; i++)
                    source.Fill(options, brush, list[i]);
            }
            else if(paths is IReadOnlyList<IPath> rlist)
            {
                int c = rlist.Count;
                for (int i = 0; i < c; i++)
                    source.Fill(options, brush, rlist[i]);
            }
            else
            {
                foreach (IPath s in paths)
                    source.Fill(options, brush, s);
            }
            return source;
        }

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, IBrush<TPixel> brush, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(GraphicsOptions.Default, brush, paths);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            IBrush brush,
            IPathCollection paths) =>
            source.Fill(GraphicsOptions.Default, brush, paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathCollectionExtensions.cs

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, GraphicsOptions options, TPixel color, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(options, new SolidBrush<TPixel>(color), paths);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            GraphicsOptions options,
            Color color,
            IPathCollection paths) =>
            source.Fill(options, new SolidBrush(color), paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathCollectionExtensions.cs

        /// <summary>
        /// Flood fills the image in the shape of the provided polygon with the specified brush.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="paths">The paths.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/FillPathCollectionExtensions.cs
        public static IImageProcessingContext<TPixel> Fill<TPixel>(this IImageProcessingContext<TPixel> source, TPixel color, IPathCollection paths)
            where TPixel : unmanaged, IPixel<TPixel>
            => source.Fill(new SolidBrush<TPixel>(color), paths);
=======
        public static IImageProcessingContext Fill(
            this IImageProcessingContext source,
            Color color,
            IPathCollection paths) =>
            source.Fill(new SolidBrush(color), paths);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/Extensions/FillPathCollectionExtensions.cs
    }
}