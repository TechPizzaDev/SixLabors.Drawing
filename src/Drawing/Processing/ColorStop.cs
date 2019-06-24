// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Diagnostics;

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// A struct that defines a single color stop.
    /// </summary>
    [DebuggerDisplay("ColorStop({Ratio} -> {Color}")]
<<<<<<< HEAD:src/ImageSharp.Drawing/Processing/ColorStop{TPixel}.cs
    public struct ColorStop<TPixel>
        where TPixel : unmanaged, IPixel<TPixel>
=======
    public readonly struct ColorStop
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7:src/ImageSharp.Drawing/Processing/ColorStop.cs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorStop" /> struct.
        /// </summary>
        /// <param name="ratio">Where should it be? 0 is at the start, 1 at the end of the Gradient.</param>
        /// <param name="color">What color should be used at that point?</param>
        public ColorStop(float ratio, in Color color)
        {
            this.Ratio = ratio;
            this.Color = color;
        }

        /// <summary>
        /// Gets the point along the defined gradient axis.
        /// </summary>
        public float Ratio { get; }

        /// <summary>
        /// Gets the color to be used.
        /// </summary>
        public Color Color { get; }
    }
}