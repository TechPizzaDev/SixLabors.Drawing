// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// A collection of methods for creating generic brushes.
    /// </summary>
    /// <returns>A New <see cref="PatternBrush"/></returns>
    public static class Brushes
    {
        /// <summary>
        /// Percent10 Hatch Pattern
        /// </summary>
        /// ---> x axis
        /// ^
        /// | y - axis
        /// |
        /// see PatternBrush for details about how to make new patterns work
        private static readonly bool[,] Percent10Pattern =
        {
            { true, false, false, false },
            { false, false, false, false },
            { false, false, true, false },
            { false, false, false, false }
        };

        /// <summary>
        /// Percent20 pattern.
        /// </summary>
        private static readonly bool[,] Percent20Pattern =
        {
            { true,  false, false, false },
            { false, false, true,  false },
            { true,  false, false, false },
            { false, false, true,  false }
        };

        /// <summary>
        /// Horizontal Hatch Pattern
        /// </summary>
        private static readonly bool[,] HorizontalPattern =
        {
            { false },
            { true },
            { false },
            { false }
        };

        /// <summary>
        /// Min Pattern
        /// </summary>
        private static readonly bool[,] MinPattern =
        {
            { false },
            { false },
            { false },
            { true }
        };

        /// <summary>
        /// Vertical Pattern
        /// </summary>
        private static readonly bool[,] VerticalPattern =
        {
            { false, true, false, false },
        };

        /// <summary>
        /// Forward Diagonal Pattern
        /// </summary>
        private static readonly bool[,] ForwardDiagonalPattern =
        {
            { false, false, false, true },
            { false, false, true, false },
            { false, true, false, false },
            { true,  false, false, false }
        };

        /// <summary>
        /// Backward Diagonal Pattern
        /// </summary>
        private static readonly bool[,] BackwardDiagonalPattern =
        {
            { true, false, false, false },
            { false, true, false, false },
            { false, false, true, false },
            { false, false, false, true }
        };

        /// <summary>
        /// Create as brush that will paint a solid color
        /// </summary>
        /// <param name="color">The color.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static SolidBrush<TPixel> Solid<TPixel>(TPixel color)
            where TPixel : unmanaged, IPixel<TPixel>
            => new SolidBrush<TPixel>(color);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static SolidBrush Solid(Color color) => new SolidBrush(color);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Percent10 Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Percent10<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, Percent10Pattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Percent10(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, Percent10Pattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Percent10 Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Percent10<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, Percent10Pattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Percent10(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, Percent10Pattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Percent20 Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Percent20<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, Percent20Pattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Percent20(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, Percent20Pattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Percent20 Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Percent20<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, Percent20Pattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Percent20(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, Percent20Pattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Horizontal Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Horizontal<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, HorizontalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Horizontal(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, HorizontalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Horizontal Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Horizontal<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, HorizontalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Horizontal(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, HorizontalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Min Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Min<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, MinPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Min(Color foreColor) => new PatternBrush(foreColor, Color.Transparent, MinPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Min Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Min<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, MinPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Min(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, MinPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Vertical Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Vertical<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, VerticalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Vertical(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, VerticalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Vertical Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> Vertical<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, VerticalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush Vertical(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, VerticalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Forward Diagonal Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> ForwardDiagonal<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, ForwardDiagonalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush ForwardDiagonal(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, ForwardDiagonalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Forward Diagonal Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> ForwardDiagonal<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, ForwardDiagonalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush ForwardDiagonal(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, ForwardDiagonalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Backward Diagonal Hatch Pattern with the specified foreground color and a
        /// transparent background.
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> BackwardDiagonal<TPixel>(TPixel foreColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, NamedColors<TPixel>.Transparent, BackwardDiagonalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush BackwardDiagonal(Color foreColor) =>
            new PatternBrush(foreColor, Color.Transparent, BackwardDiagonalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create as brush that will paint a Backward Diagonal Hatch Pattern with the specified colors
        /// </summary>
        /// <param name="foreColor">Color of the foreground.</param>
        /// <param name="backColor">Color of the background.</param>
<<<<<<< HEAD
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <returns>A New <see cref="PatternBrush{TPixel}"/></returns>
        public static PatternBrush<TPixel> BackwardDiagonal<TPixel>(TPixel foreColor, TPixel backColor)
            where TPixel : unmanaged, IPixel<TPixel>
            => new PatternBrush<TPixel>(foreColor, backColor, BackwardDiagonalPattern);
=======
        /// <returns>A New <see cref="PatternBrush"/></returns>
        public static PatternBrush BackwardDiagonal(Color foreColor, Color backColor) =>
            new PatternBrush(foreColor, backColor, BackwardDiagonalPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
    }
}