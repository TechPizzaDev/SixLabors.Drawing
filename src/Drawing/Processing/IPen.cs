// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Interface representing the pattern and size of the stroke to apply with a Pen.
    /// </summary>
<<<<<<< HEAD
    /// <typeparam name="TPixel">The type of the color.</typeparam>
    public interface IPen<TPixel> : IPen
            where TPixel : unmanaged, IPixel<TPixel>
=======
    public interface IPen
>>>>>>> 692e244f9ab4adfd57e5c7a8636fd6fc59dc86d7
    {
        /// <summary>
        /// Gets the stroke fill.
        /// </summary>
        IBrush StrokeFill { get; }

        /// <summary>
        /// Gets the width to apply to the stroke
        /// </summary>
        float StrokeWidth { get; }

        /// <summary>
        /// Gets the stoke pattern.
        /// </summary>
        ReadOnlySpan<float> StrokePattern { get; }
    }
}