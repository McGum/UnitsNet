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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LuminousIntensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LuminousIntensityTestsBase : QuantityTestsBase
    {
        protected abstract double CandelaInOneCandela { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CandelaTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(LuminousIntensityUnit unit)
        {
            return unit switch
            {
                LuminousIntensityUnit.Candela => (CandelaInOneCandela, CandelaTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { LuminousIntensityUnit.Candela },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LuminousIntensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LuminousIntensityUnit.Candela, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.PositiveInfinity, LuminousIntensityUnit.Candela));
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NegativeInfinity, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LuminousIntensity(double.NaN, LuminousIntensityUnit.Candela));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LuminousIntensity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new LuminousIntensity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (LuminousIntensity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void LuminousIntensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LuminousIntensity(1, LuminousIntensityUnit.Candela);

            QuantityInfo<LuminousIntensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LuminousIntensity.Zero, quantityInfo.Zero);
            Assert.Equal("LuminousIntensity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<LuminousIntensityUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void CandelaToLuminousIntensityUnits()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.Candela, CandelaTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LuminousIntensity.From(1, LuminousIntensityUnit.Candela);
            AssertEx.EqualTolerance(1, quantity00.Candela, CandelaTolerance);
            Assert.Equal(LuminousIntensityUnit.Candela, quantity00.Unit);

        }

        [Fact]
        public void FromCandela_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NegativeInfinity));
        }

        [Fact]
        public void FromCandela_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LuminousIntensity.FromCandela(double.NaN));
        }

        [Fact]
        public void As()
        {
            var candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(CandelaInOneCandela, candela.As(LuminousIntensityUnit.Candela), CandelaTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new LuminousIntensity(value: 1, unit: LuminousIntensity.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = LuminousIntensity.Parse("1 cd", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Candela, CandelaTolerance);
                Assert.Equal(LuminousIntensityUnit.Candela, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(LuminousIntensity.TryParse("1 cd", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Candela, CandelaTolerance);
                Assert.Equal(LuminousIntensityUnit.Candela, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = LuminousIntensity.ParseUnit("cd", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LuminousIntensityUnit.Candela, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(LuminousIntensity.TryParseUnit("cd", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LuminousIntensityUnit.Candela, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(LuminousIntensityUnit unit)
        {
            var inBaseUnits = LuminousIntensity.From(1.0, LuminousIntensity.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(LuminousIntensityUnit unit)
        {
            var quantity = LuminousIntensity.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(LuminousIntensityUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = LuminousIntensity.Units.First(u => u != LuminousIntensity.BaseUnit);

            var quantity = LuminousIntensity.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(LuminousIntensityUnit unit)
        {
            var quantity = default(LuminousIntensity);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(1, LuminousIntensity.FromCandela(candela.Candela).Candela, CandelaTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LuminousIntensity v = LuminousIntensity.FromCandela(1);
            AssertEx.EqualTolerance(-1, -v.Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(3)-v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (v + v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (v*10).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(10, (10*v).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, (LuminousIntensity.FromCandela(10)/5).Candela, CandelaTolerance);
            AssertEx.EqualTolerance(2, LuminousIntensity.FromCandela(10)/LuminousIntensity.FromCandela(5), CandelaTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LuminousIntensity oneCandela = LuminousIntensity.FromCandela(1);
            LuminousIntensity twoCandela = LuminousIntensity.FromCandela(2);

            Assert.True(oneCandela < twoCandela);
            Assert.True(oneCandela <= twoCandela);
            Assert.True(twoCandela > oneCandela);
            Assert.True(twoCandela >= oneCandela);

            Assert.False(oneCandela > twoCandela);
            Assert.False(oneCandela >= twoCandela);
            Assert.False(twoCandela < oneCandela);
            Assert.False(twoCandela <= oneCandela);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Equal(0, candela.CompareTo(candela));
            Assert.True(candela.CompareTo(LuminousIntensity.Zero) > 0);
            Assert.True(LuminousIntensity.Zero.CompareTo(candela) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentException>(() => candela.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentNullException>(() => candela.CompareTo(null));
        }

        [Theory]
        [InlineData(1, LuminousIntensityUnit.Candela, 1, LuminousIntensityUnit.Candela, true)]  // Same value and unit.
        [InlineData(1, LuminousIntensityUnit.Candela, 2, LuminousIntensityUnit.Candela, false)] // Different value.
        [InlineData(2, LuminousIntensityUnit.Candela, 1, LuminousIntensityUnit.Candela, false)] // Different value and unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, LuminousIntensityUnit unitA, double valueB, LuminousIntensityUnit unitB, bool expectEqual)
        {
            var a = new LuminousIntensity(valueA, unitA);
            var b = new LuminousIntensity(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = LuminousIntensity.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = LuminousIntensity.FromCandela(1);
            Assert.True(v.Equals(LuminousIntensity.FromCandela(1), CandelaTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LuminousIntensity.Zero, CandelaTolerance, ComparisonType.Relative));
            Assert.True(LuminousIntensity.FromCandela(100).Equals(LuminousIntensity.FromCandela(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(LuminousIntensity.FromCandela(100).Equals(LuminousIntensity.FromCandela(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = LuminousIntensity.FromCandela(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(LuminousIntensity.FromCandela(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LuminousIntensity candela = LuminousIntensity.FromCandela(1);
            Assert.False(candela.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LuminousIntensityUnit)).Cast<LuminousIntensityUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LuminousIntensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cd", new LuminousIntensity(1, LuminousIntensityUnit.Candela).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cd", new LuminousIntensity(1, LuminousIntensityUnit.Candela).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s1"));
                Assert.Equal("0.12 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s2"));
                Assert.Equal("0.123 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s3"));
                Assert.Equal("0.1235 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s1", culture));
            Assert.Equal("0.12 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s2", culture));
            Assert.Equal("0.123 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s3", culture));
            Assert.Equal("0.1235 cd", new LuminousIntensity(0.123456, LuminousIntensityUnit.Candela).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(LuminousIntensity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LuminousIntensityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(LuminousIntensity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(LuminousIntensity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = LuminousIntensity.FromCandela(1.0);
            Assert.Equal(new {LuminousIntensity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = LuminousIntensity.FromCandela(value);
            Assert.Equal(LuminousIntensity.FromCandela(-value), -quantity);
        }
    }
}
