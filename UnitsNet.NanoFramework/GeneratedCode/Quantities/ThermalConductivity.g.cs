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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Thermal conductivity is the property of a material to conduct heat.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Thermal_Conductivity
    /// </remarks>
    public struct  ThermalConductivity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ThermalConductivityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ThermalConductivityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ThermalConductivity(double value, ThermalConductivityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ThermalConductivity, which is Second. All conversions go via this value.
        /// </summary>
        public static ThermalConductivityUnit BaseUnit { get; } = ThermalConductivityUnit.WattPerMeterKelvin;

        /// <summary>
        /// Represents the largest possible value of ThermalConductivity.
        /// </summary>
        public static ThermalConductivity MaxValue { get; } = new ThermalConductivity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ThermalConductivity.
        /// </summary>
        public static ThermalConductivity MinValue { get; } = new ThermalConductivity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ThermalConductivity Zero { get; } = new ThermalConductivity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ThermalConductivityUnit.BtuPerHourFootFahrenheit"/>
        /// </summary>
        public double BtusPerHourFootFahrenheit => As(ThermalConductivityUnit.BtuPerHourFootFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ThermalConductivityUnit.WattPerMeterKelvin"/>
        /// </summary>
        public double WattsPerMeterKelvin => As(ThermalConductivityUnit.WattPerMeterKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ThermalConductivity"/> from <see cref="ThermalConductivityUnit.BtuPerHourFootFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalConductivity FromBtusPerHourFootFahrenheit(double btusperhourfootfahrenheit) => new ThermalConductivity(btusperhourfootfahrenheit, ThermalConductivityUnit.BtuPerHourFootFahrenheit);

        /// <summary>
        ///     Creates a <see cref="ThermalConductivity"/> from <see cref="ThermalConductivityUnit.WattPerMeterKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalConductivity FromWattsPerMeterKelvin(double wattspermeterkelvin) => new ThermalConductivity(wattspermeterkelvin, ThermalConductivityUnit.WattPerMeterKelvin);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ThermalConductivityUnit" /> to <see cref="ThermalConductivity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ThermalConductivity unit value.</returns>
        public static ThermalConductivity From(double value, ThermalConductivityUnit fromUnit)
        {
            return new ThermalConductivity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ThermalConductivityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ThermalConductivity to another ThermalConductivity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ThermalConductivity with the specified unit.</returns>
                public ThermalConductivity ToUnit(ThermalConductivityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ThermalConductivity(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        ThermalConductivityUnit.BtuPerHourFootFahrenheit => _value * 1.73073467,
                        ThermalConductivityUnit.WattPerMeterKelvin => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ThermalConductivityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ThermalConductivityUnit.BtuPerHourFootFahrenheit => baseUnitValue / 1.73073467,
                        ThermalConductivityUnit.WattPerMeterKelvin => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

