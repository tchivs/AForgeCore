// AForgeCore Image Processing Library
// AForgeCore.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright ?Andrew Kirillov, 2005-2009
// andrew.kirillov@aforgenet.com
//

namespace AForgeCore.Imaging.ComplexFilters
{
    using System;
    using AForgeCore;
    using AForgeCore.Math;

    /// <summary>
    /// Image processing filter, which operates with Fourier transformed
    /// complex image.
    /// </summary>
    /// 
    /// <remarks>The interface defines the set of methods, which should be
    /// provided by all image processing filter, which operate with Fourier
    /// transformed complex image.</remarks>
    /// 
    public interface IComplexFilter
    {
        /// <summary>
        /// Apply filter to complex image.
        /// </summary>
        /// 
        /// <param name="complexImage">Complex image to apply filter to.</param>
        /// 
        void Apply( ComplexImage complexImage );
    }
}
