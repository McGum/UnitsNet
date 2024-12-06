//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToRatioChangeRate
{
    /// <summary>
    /// A number to RatioChangeRate Extensions
    /// </summary>
    public static class NumberToRatioChangeRateExtensions
    {
        /// <inheritdoc cref="RatioChangeRate.FromDecimalFractionsPerSecond(UnitsNet.QuantityValue)" />
        public static RatioChangeRate DecimalFractionsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RatioChangeRate.FromDecimalFractionsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RatioChangeRate.FromPercentsPerSecond(UnitsNet.QuantityValue)" />
        public static RatioChangeRate PercentsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RatioChangeRate.FromPercentsPerSecond(Convert.ToDouble(value));

    }
}
