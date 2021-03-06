﻿//------------------------------------------------------------------------------
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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of FuelEfficiency.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FuelEfficiencyTestsBase
    {
        protected abstract double KilometersPerLitersInOneLiterPer100Kilometers { get; }
        protected abstract double LitersPer100KilometersInOneLiterPer100Kilometers { get; }
        protected abstract double MilesPerUkGallonInOneLiterPer100Kilometers { get; }
        protected abstract double MilesPerUsGallonInOneLiterPer100Kilometers { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilometersPerLitersTolerance { get { return 1e-5; } }
        protected virtual double LitersPer100KilometersTolerance { get { return 1e-5; } }
        protected virtual double MilesPerUkGallonTolerance { get { return 1e-5; } }
        protected virtual double MilesPerUsGallonTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency((double)0.0, FuelEfficiencyUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.PositiveInfinity, FuelEfficiencyUnit.LiterPer100Kilometers));
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.NegativeInfinity, FuelEfficiencyUnit.LiterPer100Kilometers));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FuelEfficiency(double.NaN, FuelEfficiencyUnit.LiterPer100Kilometers));
        }

        [Fact]
        public void LiterPer100KilometersToFuelEfficiencyUnits()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, literper100kilometers.KilometersPerLiters, KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, literper100kilometers.LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, literper100kilometers.MilesPerUkGallon, MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, literper100kilometers.MilesPerUsGallon, MilesPerUsGallonTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, FuelEfficiency.From(1, FuelEfficiencyUnit.KilometerPerLiter).KilometersPerLiters, KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.From(1, FuelEfficiencyUnit.LiterPer100Kilometers).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.From(1, FuelEfficiencyUnit.MilePerUkGallon).MilesPerUkGallon, MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.From(1, FuelEfficiencyUnit.MilePerUsGallon).MilesPerUsGallon, MilesPerUsGallonTolerance);
        }

        [Fact]
        public void FromLitersPer100Kilometers_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.NegativeInfinity));
        }

        [Fact]
        public void FromLitersPer100Kilometers_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FuelEfficiency.FromLitersPer100Kilometers(double.NaN));
        }

        [Fact]
        public void As()
        {
            var literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.KilometerPerLiter), KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.LiterPer100Kilometers), LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.MilePerUkGallon), MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, literper100kilometers.As(FuelEfficiencyUnit.MilePerUsGallon), MilesPerUsGallonTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);

            var kilometerperliterQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.KilometerPerLiter);
            AssertEx.EqualTolerance(KilometersPerLitersInOneLiterPer100Kilometers, (double)kilometerperliterQuantity.Value, KilometersPerLitersTolerance);
            Assert.Equal(FuelEfficiencyUnit.KilometerPerLiter, kilometerperliterQuantity.Unit);

            var literper100kilometersQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.LiterPer100Kilometers);
            AssertEx.EqualTolerance(LitersPer100KilometersInOneLiterPer100Kilometers, (double)literper100kilometersQuantity.Value, LitersPer100KilometersTolerance);
            Assert.Equal(FuelEfficiencyUnit.LiterPer100Kilometers, literper100kilometersQuantity.Unit);

            var mileperukgallonQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.MilePerUkGallon);
            AssertEx.EqualTolerance(MilesPerUkGallonInOneLiterPer100Kilometers, (double)mileperukgallonQuantity.Value, MilesPerUkGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUkGallon, mileperukgallonQuantity.Unit);

            var mileperusgallonQuantity = literper100kilometers.ToUnit(FuelEfficiencyUnit.MilePerUsGallon);
            AssertEx.EqualTolerance(MilesPerUsGallonInOneLiterPer100Kilometers, (double)mileperusgallonQuantity.Value, MilesPerUsGallonTolerance);
            Assert.Equal(FuelEfficiencyUnit.MilePerUsGallon, mileperusgallonQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromKilometersPerLiters(literper100kilometers.KilometersPerLiters).LitersPer100Kilometers, KilometersPerLitersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromLitersPer100Kilometers(literper100kilometers.LitersPer100Kilometers).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromMilesPerUkGallon(literper100kilometers.MilesPerUkGallon).LitersPer100Kilometers, MilesPerUkGallonTolerance);
            AssertEx.EqualTolerance(1, FuelEfficiency.FromMilesPerUsGallon(literper100kilometers.MilesPerUsGallon).LitersPer100Kilometers, MilesPerUsGallonTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            FuelEfficiency v = FuelEfficiency.FromLitersPer100Kilometers(1);
            AssertEx.EqualTolerance(-1, -v.LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (FuelEfficiency.FromLitersPer100Kilometers(3)-v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (v + v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(10, (v*10).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(10, (10*v).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, (FuelEfficiency.FromLitersPer100Kilometers(10)/5).LitersPer100Kilometers, LitersPer100KilometersTolerance);
            AssertEx.EqualTolerance(2, FuelEfficiency.FromLitersPer100Kilometers(10)/FuelEfficiency.FromLitersPer100Kilometers(5), LitersPer100KilometersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            FuelEfficiency oneLiterPer100Kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            FuelEfficiency twoLitersPer100Kilometers = FuelEfficiency.FromLitersPer100Kilometers(2);

            Assert.True(oneLiterPer100Kilometers < twoLitersPer100Kilometers);
            Assert.True(oneLiterPer100Kilometers <= twoLitersPer100Kilometers);
            Assert.True(twoLitersPer100Kilometers > oneLiterPer100Kilometers);
            Assert.True(twoLitersPer100Kilometers >= oneLiterPer100Kilometers);

            Assert.False(oneLiterPer100Kilometers > twoLitersPer100Kilometers);
            Assert.False(oneLiterPer100Kilometers >= twoLitersPer100Kilometers);
            Assert.False(twoLitersPer100Kilometers < oneLiterPer100Kilometers);
            Assert.False(twoLitersPer100Kilometers <= oneLiterPer100Kilometers);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Equal(0, literper100kilometers.CompareTo(literper100kilometers));
            Assert.True(literper100kilometers.CompareTo(FuelEfficiency.Zero) > 0);
            Assert.True(FuelEfficiency.Zero.CompareTo(literper100kilometers) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Throws<ArgumentException>(() => literper100kilometers.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.Throws<ArgumentNullException>(() => literper100kilometers.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = FuelEfficiency.FromLitersPer100Kilometers(1);
            var b = FuelEfficiency.FromLitersPer100Kilometers(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = FuelEfficiency.FromLitersPer100Kilometers(1);
            var b = FuelEfficiency.FromLitersPer100Kilometers(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.True(v.Equals(FuelEfficiency.FromLitersPer100Kilometers(1), LitersPer100KilometersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(FuelEfficiency.Zero, LitersPer100KilometersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.False(literper100kilometers.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            FuelEfficiency literper100kilometers = FuelEfficiency.FromLitersPer100Kilometers(1);
            Assert.False(literper100kilometers.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(FuelEfficiencyUnit.Undefined, FuelEfficiency.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(FuelEfficiencyUnit)).Cast<FuelEfficiencyUnit>();
            foreach(var unit in units)
            {
                if(unit == FuelEfficiencyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(FuelEfficiency.BaseDimensions is null);
        }
    }
}
