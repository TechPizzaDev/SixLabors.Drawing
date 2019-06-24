// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Contains a collection of common Pen styles
    /// </summary>
    public static class Pens
    {
        private static readonly float[] DashDotPattern = { 3f, 1f, 1f, 1f };
        private static readonly float[] DashDotDotPattern = { 3f, 1f, 1f, 1f, 1f, 1f };
        private static readonly float[] DottedPattern = { 1f, 1f };
        private static readonly float[] DashedPattern = { 3f, 1f };
        internal static readonly float[] EmptyPattern = new float[0];

        /// <summary>
        /// Create a solid pen with out any drawing patterns
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Solid<TPixel>(TPixel color, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(color, width);
=======
        public static Pen Solid(Color color, float width) => new Pen(color, width);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a solid pen with out any drawing patterns
        /// </summary>
        /// <param name="brush">The brush.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Solid<TPixel>(IBrush<TPixel> brush, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(brush, width);
=======
        public static Pen Solid(IBrush brush, float width) => new Pen(brush, width);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash' drawing patterns
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Dash<TPixel>(TPixel color, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(color, width, DashedPattern);
=======
        public static Pen Dash(Color color, float width) => new Pen(color, width, DashedPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash' drawing patterns
        /// </summary>
        /// <param name="brush">The brush.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Dash<TPixel>(IBrush<TPixel> brush, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(brush, width, DashedPattern);
=======
        public static Pen Dash(IBrush brush, float width) => new Pen(brush, width, DashedPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dot' drawing patterns
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Dot<TPixel>(TPixel color, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(color, width, DottedPattern);
=======
        public static Pen Dot(Color color, float width) => new Pen(color, width, DottedPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dot' drawing patterns
        /// </summary>
        /// <param name="brush">The brush.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> Dot<TPixel>(IBrush<TPixel> brush, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(brush, width, DottedPattern);
=======
        public static Pen Dot(IBrush brush, float width) => new Pen(brush, width, DottedPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash Dot' drawing patterns
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> DashDot<TPixel>(TPixel color, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(color, width, DashDotPattern);
=======
        public static Pen DashDot(Color color, float width) => new Pen(color, width, DashDotPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash Dot' drawing patterns
        /// </summary>
        /// <param name="brush">The brush.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> DashDot<TPixel>(IBrush<TPixel> brush, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(brush, width, DashDotPattern);
=======
        public static Pen DashDot(IBrush brush, float width) => new Pen(brush, width, DashDotPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash Dot Dot' drawing patterns
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> DashDotDot<TPixel>(TPixel color, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(color, width, DashDotDotPattern);
=======
        public static Pen DashDotDot(Color color, float width) => new Pen(color, width, DashDotDotPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7

        /// <summary>
        /// Create a pen with a 'Dash Dot Dot' drawing patterns
        /// </summary>
        /// <param name="brush">The brush.</param>
        /// <param name="width">The width.</param>
        /// <returns>The Pen</returns>
<<<<<<< HEAD
        public static Pen<TPixel> DashDotDot<TPixel>(IBrush<TPixel> brush, float width)
            where TPixel : unmanaged, IPixel<TPixel>
            => new Pen<TPixel>(brush, width, DashDotDotPattern);
=======
        public static Pen DashDotDot(IBrush brush, float width) => new Pen(brush, width, DashDotDotPattern);
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
    }
}