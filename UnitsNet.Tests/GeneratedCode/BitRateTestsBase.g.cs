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
    /// Test of BitRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class BitRateTestsBase
    {
        protected abstract double BitsPerSecondInOneBitPerSecond { get; }
        protected abstract double BytesPerSecondInOneBitPerSecond { get; }
        protected abstract double ExabitsPerSecondInOneBitPerSecond { get; }
        protected abstract double ExabytesPerSecondInOneBitPerSecond { get; }
        protected abstract double ExbibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double ExbibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double GibibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double GibibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double GigabitsPerSecondInOneBitPerSecond { get; }
        protected abstract double GigabytesPerSecondInOneBitPerSecond { get; }
        protected abstract double KibibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double KibibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double KilobitsPerSecondInOneBitPerSecond { get; }
        protected abstract double KilobytesPerSecondInOneBitPerSecond { get; }
        protected abstract double MebibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double MebibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double MegabitsPerSecondInOneBitPerSecond { get; }
        protected abstract double MegabytesPerSecondInOneBitPerSecond { get; }
        protected abstract double PebibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double PebibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double PetabitsPerSecondInOneBitPerSecond { get; }
        protected abstract double PetabytesPerSecondInOneBitPerSecond { get; }
        protected abstract double TebibitsPerSecondInOneBitPerSecond { get; }
        protected abstract double TebibytesPerSecondInOneBitPerSecond { get; }
        protected abstract double TerabitsPerSecondInOneBitPerSecond { get; }
        protected abstract double TerabytesPerSecondInOneBitPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double BytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double ExabitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double ExabytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double ExbibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double ExbibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double GibibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double GibibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double GigabitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double GigabytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KibibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KibibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilobitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilobytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MebibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MebibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MegabitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MegabytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PebibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PebibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PetabitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PetabytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TebibitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TebibytesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TerabitsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TerabytesPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BitRate((decimal)0.0, BitRateUnit.Undefined));
        }

        [Fact]
        public void BitPerSecondToBitRateUnits()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            AssertEx.EqualTolerance(BitsPerSecondInOneBitPerSecond, bitpersecond.BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(BytesPerSecondInOneBitPerSecond, bitpersecond.BytesPerSecond, BytesPerSecondTolerance);
            AssertEx.EqualTolerance(ExabitsPerSecondInOneBitPerSecond, bitpersecond.ExabitsPerSecond, ExabitsPerSecondTolerance);
            AssertEx.EqualTolerance(ExabytesPerSecondInOneBitPerSecond, bitpersecond.ExabytesPerSecond, ExabytesPerSecondTolerance);
            AssertEx.EqualTolerance(ExbibitsPerSecondInOneBitPerSecond, bitpersecond.ExbibitsPerSecond, ExbibitsPerSecondTolerance);
            AssertEx.EqualTolerance(ExbibytesPerSecondInOneBitPerSecond, bitpersecond.ExbibytesPerSecond, ExbibytesPerSecondTolerance);
            AssertEx.EqualTolerance(GibibitsPerSecondInOneBitPerSecond, bitpersecond.GibibitsPerSecond, GibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(GibibytesPerSecondInOneBitPerSecond, bitpersecond.GibibytesPerSecond, GibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(GigabitsPerSecondInOneBitPerSecond, bitpersecond.GigabitsPerSecond, GigabitsPerSecondTolerance);
            AssertEx.EqualTolerance(GigabytesPerSecondInOneBitPerSecond, bitpersecond.GigabytesPerSecond, GigabytesPerSecondTolerance);
            AssertEx.EqualTolerance(KibibitsPerSecondInOneBitPerSecond, bitpersecond.KibibitsPerSecond, KibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(KibibytesPerSecondInOneBitPerSecond, bitpersecond.KibibytesPerSecond, KibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(KilobitsPerSecondInOneBitPerSecond, bitpersecond.KilobitsPerSecond, KilobitsPerSecondTolerance);
            AssertEx.EqualTolerance(KilobytesPerSecondInOneBitPerSecond, bitpersecond.KilobytesPerSecond, KilobytesPerSecondTolerance);
            AssertEx.EqualTolerance(MebibitsPerSecondInOneBitPerSecond, bitpersecond.MebibitsPerSecond, MebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(MebibytesPerSecondInOneBitPerSecond, bitpersecond.MebibytesPerSecond, MebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(MegabitsPerSecondInOneBitPerSecond, bitpersecond.MegabitsPerSecond, MegabitsPerSecondTolerance);
            AssertEx.EqualTolerance(MegabytesPerSecondInOneBitPerSecond, bitpersecond.MegabytesPerSecond, MegabytesPerSecondTolerance);
            AssertEx.EqualTolerance(PebibitsPerSecondInOneBitPerSecond, bitpersecond.PebibitsPerSecond, PebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(PebibytesPerSecondInOneBitPerSecond, bitpersecond.PebibytesPerSecond, PebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(PetabitsPerSecondInOneBitPerSecond, bitpersecond.PetabitsPerSecond, PetabitsPerSecondTolerance);
            AssertEx.EqualTolerance(PetabytesPerSecondInOneBitPerSecond, bitpersecond.PetabytesPerSecond, PetabytesPerSecondTolerance);
            AssertEx.EqualTolerance(TebibitsPerSecondInOneBitPerSecond, bitpersecond.TebibitsPerSecond, TebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(TebibytesPerSecondInOneBitPerSecond, bitpersecond.TebibytesPerSecond, TebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(TerabitsPerSecondInOneBitPerSecond, bitpersecond.TerabitsPerSecond, TerabitsPerSecondTolerance);
            AssertEx.EqualTolerance(TerabytesPerSecondInOneBitPerSecond, bitpersecond.TerabytesPerSecond, TerabytesPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.BitPerSecond).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.BytePerSecond).BytesPerSecond, BytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.ExabitPerSecond).ExabitsPerSecond, ExabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.ExabytePerSecond).ExabytesPerSecond, ExabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.ExbibitPerSecond).ExbibitsPerSecond, ExbibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.ExbibytePerSecond).ExbibytesPerSecond, ExbibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.GibibitPerSecond).GibibitsPerSecond, GibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.GibibytePerSecond).GibibytesPerSecond, GibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.GigabitPerSecond).GigabitsPerSecond, GigabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.GigabytePerSecond).GigabytesPerSecond, GigabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.KibibitPerSecond).KibibitsPerSecond, KibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.KibibytePerSecond).KibibytesPerSecond, KibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.KilobitPerSecond).KilobitsPerSecond, KilobitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.KilobytePerSecond).KilobytesPerSecond, KilobytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.MebibitPerSecond).MebibitsPerSecond, MebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.MebibytePerSecond).MebibytesPerSecond, MebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.MegabitPerSecond).MegabitsPerSecond, MegabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.MegabytePerSecond).MegabytesPerSecond, MegabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.PebibitPerSecond).PebibitsPerSecond, PebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.PebibytePerSecond).PebibytesPerSecond, PebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.PetabitPerSecond).PetabitsPerSecond, PetabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.PetabytePerSecond).PetabytesPerSecond, PetabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.TebibitPerSecond).TebibitsPerSecond, TebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.TebibytePerSecond).TebibytesPerSecond, TebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.TerabitPerSecond).TerabitsPerSecond, TerabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.From(1, BitRateUnit.TerabytePerSecond).TerabytesPerSecond, TerabytesPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var bitpersecond = BitRate.FromBitsPerSecond(1);
            AssertEx.EqualTolerance(BitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.BitPerSecond), BitsPerSecondTolerance);
            AssertEx.EqualTolerance(BytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.BytePerSecond), BytesPerSecondTolerance);
            AssertEx.EqualTolerance(ExabitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.ExabitPerSecond), ExabitsPerSecondTolerance);
            AssertEx.EqualTolerance(ExabytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.ExabytePerSecond), ExabytesPerSecondTolerance);
            AssertEx.EqualTolerance(ExbibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.ExbibitPerSecond), ExbibitsPerSecondTolerance);
            AssertEx.EqualTolerance(ExbibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.ExbibytePerSecond), ExbibytesPerSecondTolerance);
            AssertEx.EqualTolerance(GibibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.GibibitPerSecond), GibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(GibibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.GibibytePerSecond), GibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(GigabitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.GigabitPerSecond), GigabitsPerSecondTolerance);
            AssertEx.EqualTolerance(GigabytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.GigabytePerSecond), GigabytesPerSecondTolerance);
            AssertEx.EqualTolerance(KibibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.KibibitPerSecond), KibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(KibibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.KibibytePerSecond), KibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(KilobitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.KilobitPerSecond), KilobitsPerSecondTolerance);
            AssertEx.EqualTolerance(KilobytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.KilobytePerSecond), KilobytesPerSecondTolerance);
            AssertEx.EqualTolerance(MebibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.MebibitPerSecond), MebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(MebibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.MebibytePerSecond), MebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(MegabitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.MegabitPerSecond), MegabitsPerSecondTolerance);
            AssertEx.EqualTolerance(MegabytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.MegabytePerSecond), MegabytesPerSecondTolerance);
            AssertEx.EqualTolerance(PebibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.PebibitPerSecond), PebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(PebibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.PebibytePerSecond), PebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(PetabitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.PetabitPerSecond), PetabitsPerSecondTolerance);
            AssertEx.EqualTolerance(PetabytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.PetabytePerSecond), PetabytesPerSecondTolerance);
            AssertEx.EqualTolerance(TebibitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.TebibitPerSecond), TebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(TebibytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.TebibytePerSecond), TebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(TerabitsPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.TerabitPerSecond), TerabitsPerSecondTolerance);
            AssertEx.EqualTolerance(TerabytesPerSecondInOneBitPerSecond, bitpersecond.As(BitRateUnit.TerabytePerSecond), TerabytesPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var bitpersecond = BitRate.FromBitsPerSecond(1);

            var bitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.BitPerSecond);
            AssertEx.EqualTolerance(BitsPerSecondInOneBitPerSecond, (double)bitpersecondQuantity.Value, BitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.BitPerSecond, bitpersecondQuantity.Unit);

            var bytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.BytePerSecond);
            AssertEx.EqualTolerance(BytesPerSecondInOneBitPerSecond, (double)bytepersecondQuantity.Value, BytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.BytePerSecond, bytepersecondQuantity.Unit);

            var exabitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.ExabitPerSecond);
            AssertEx.EqualTolerance(ExabitsPerSecondInOneBitPerSecond, (double)exabitpersecondQuantity.Value, ExabitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.ExabitPerSecond, exabitpersecondQuantity.Unit);

            var exabytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.ExabytePerSecond);
            AssertEx.EqualTolerance(ExabytesPerSecondInOneBitPerSecond, (double)exabytepersecondQuantity.Value, ExabytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.ExabytePerSecond, exabytepersecondQuantity.Unit);

            var exbibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.ExbibitPerSecond);
            AssertEx.EqualTolerance(ExbibitsPerSecondInOneBitPerSecond, (double)exbibitpersecondQuantity.Value, ExbibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.ExbibitPerSecond, exbibitpersecondQuantity.Unit);

            var exbibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.ExbibytePerSecond);
            AssertEx.EqualTolerance(ExbibytesPerSecondInOneBitPerSecond, (double)exbibytepersecondQuantity.Value, ExbibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.ExbibytePerSecond, exbibytepersecondQuantity.Unit);

            var gibibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.GibibitPerSecond);
            AssertEx.EqualTolerance(GibibitsPerSecondInOneBitPerSecond, (double)gibibitpersecondQuantity.Value, GibibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.GibibitPerSecond, gibibitpersecondQuantity.Unit);

            var gibibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.GibibytePerSecond);
            AssertEx.EqualTolerance(GibibytesPerSecondInOneBitPerSecond, (double)gibibytepersecondQuantity.Value, GibibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.GibibytePerSecond, gibibytepersecondQuantity.Unit);

            var gigabitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.GigabitPerSecond);
            AssertEx.EqualTolerance(GigabitsPerSecondInOneBitPerSecond, (double)gigabitpersecondQuantity.Value, GigabitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.GigabitPerSecond, gigabitpersecondQuantity.Unit);

            var gigabytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.GigabytePerSecond);
            AssertEx.EqualTolerance(GigabytesPerSecondInOneBitPerSecond, (double)gigabytepersecondQuantity.Value, GigabytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.GigabytePerSecond, gigabytepersecondQuantity.Unit);

            var kibibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.KibibitPerSecond);
            AssertEx.EqualTolerance(KibibitsPerSecondInOneBitPerSecond, (double)kibibitpersecondQuantity.Value, KibibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.KibibitPerSecond, kibibitpersecondQuantity.Unit);

            var kibibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.KibibytePerSecond);
            AssertEx.EqualTolerance(KibibytesPerSecondInOneBitPerSecond, (double)kibibytepersecondQuantity.Value, KibibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.KibibytePerSecond, kibibytepersecondQuantity.Unit);

            var kilobitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.KilobitPerSecond);
            AssertEx.EqualTolerance(KilobitsPerSecondInOneBitPerSecond, (double)kilobitpersecondQuantity.Value, KilobitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.KilobitPerSecond, kilobitpersecondQuantity.Unit);

            var kilobytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.KilobytePerSecond);
            AssertEx.EqualTolerance(KilobytesPerSecondInOneBitPerSecond, (double)kilobytepersecondQuantity.Value, KilobytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.KilobytePerSecond, kilobytepersecondQuantity.Unit);

            var mebibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.MebibitPerSecond);
            AssertEx.EqualTolerance(MebibitsPerSecondInOneBitPerSecond, (double)mebibitpersecondQuantity.Value, MebibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.MebibitPerSecond, mebibitpersecondQuantity.Unit);

            var mebibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.MebibytePerSecond);
            AssertEx.EqualTolerance(MebibytesPerSecondInOneBitPerSecond, (double)mebibytepersecondQuantity.Value, MebibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.MebibytePerSecond, mebibytepersecondQuantity.Unit);

            var megabitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.MegabitPerSecond);
            AssertEx.EqualTolerance(MegabitsPerSecondInOneBitPerSecond, (double)megabitpersecondQuantity.Value, MegabitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.MegabitPerSecond, megabitpersecondQuantity.Unit);

            var megabytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.MegabytePerSecond);
            AssertEx.EqualTolerance(MegabytesPerSecondInOneBitPerSecond, (double)megabytepersecondQuantity.Value, MegabytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.MegabytePerSecond, megabytepersecondQuantity.Unit);

            var pebibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.PebibitPerSecond);
            AssertEx.EqualTolerance(PebibitsPerSecondInOneBitPerSecond, (double)pebibitpersecondQuantity.Value, PebibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.PebibitPerSecond, pebibitpersecondQuantity.Unit);

            var pebibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.PebibytePerSecond);
            AssertEx.EqualTolerance(PebibytesPerSecondInOneBitPerSecond, (double)pebibytepersecondQuantity.Value, PebibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.PebibytePerSecond, pebibytepersecondQuantity.Unit);

            var petabitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.PetabitPerSecond);
            AssertEx.EqualTolerance(PetabitsPerSecondInOneBitPerSecond, (double)petabitpersecondQuantity.Value, PetabitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.PetabitPerSecond, petabitpersecondQuantity.Unit);

            var petabytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.PetabytePerSecond);
            AssertEx.EqualTolerance(PetabytesPerSecondInOneBitPerSecond, (double)petabytepersecondQuantity.Value, PetabytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.PetabytePerSecond, petabytepersecondQuantity.Unit);

            var tebibitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.TebibitPerSecond);
            AssertEx.EqualTolerance(TebibitsPerSecondInOneBitPerSecond, (double)tebibitpersecondQuantity.Value, TebibitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.TebibitPerSecond, tebibitpersecondQuantity.Unit);

            var tebibytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.TebibytePerSecond);
            AssertEx.EqualTolerance(TebibytesPerSecondInOneBitPerSecond, (double)tebibytepersecondQuantity.Value, TebibytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.TebibytePerSecond, tebibytepersecondQuantity.Unit);

            var terabitpersecondQuantity = bitpersecond.ToUnit(BitRateUnit.TerabitPerSecond);
            AssertEx.EqualTolerance(TerabitsPerSecondInOneBitPerSecond, (double)terabitpersecondQuantity.Value, TerabitsPerSecondTolerance);
            Assert.Equal(BitRateUnit.TerabitPerSecond, terabitpersecondQuantity.Unit);

            var terabytepersecondQuantity = bitpersecond.ToUnit(BitRateUnit.TerabytePerSecond);
            AssertEx.EqualTolerance(TerabytesPerSecondInOneBitPerSecond, (double)terabytepersecondQuantity.Value, TerabytesPerSecondTolerance);
            Assert.Equal(BitRateUnit.TerabytePerSecond, terabytepersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            AssertEx.EqualTolerance(1, BitRate.FromBitsPerSecond(bitpersecond.BitsPerSecond).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromBytesPerSecond(bitpersecond.BytesPerSecond).BitsPerSecond, BytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromExabitsPerSecond(bitpersecond.ExabitsPerSecond).BitsPerSecond, ExabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromExabytesPerSecond(bitpersecond.ExabytesPerSecond).BitsPerSecond, ExabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromExbibitsPerSecond(bitpersecond.ExbibitsPerSecond).BitsPerSecond, ExbibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromExbibytesPerSecond(bitpersecond.ExbibytesPerSecond).BitsPerSecond, ExbibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromGibibitsPerSecond(bitpersecond.GibibitsPerSecond).BitsPerSecond, GibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromGibibytesPerSecond(bitpersecond.GibibytesPerSecond).BitsPerSecond, GibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromGigabitsPerSecond(bitpersecond.GigabitsPerSecond).BitsPerSecond, GigabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromGigabytesPerSecond(bitpersecond.GigabytesPerSecond).BitsPerSecond, GigabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromKibibitsPerSecond(bitpersecond.KibibitsPerSecond).BitsPerSecond, KibibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromKibibytesPerSecond(bitpersecond.KibibytesPerSecond).BitsPerSecond, KibibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromKilobitsPerSecond(bitpersecond.KilobitsPerSecond).BitsPerSecond, KilobitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromKilobytesPerSecond(bitpersecond.KilobytesPerSecond).BitsPerSecond, KilobytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromMebibitsPerSecond(bitpersecond.MebibitsPerSecond).BitsPerSecond, MebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromMebibytesPerSecond(bitpersecond.MebibytesPerSecond).BitsPerSecond, MebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromMegabitsPerSecond(bitpersecond.MegabitsPerSecond).BitsPerSecond, MegabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromMegabytesPerSecond(bitpersecond.MegabytesPerSecond).BitsPerSecond, MegabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromPebibitsPerSecond(bitpersecond.PebibitsPerSecond).BitsPerSecond, PebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromPebibytesPerSecond(bitpersecond.PebibytesPerSecond).BitsPerSecond, PebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromPetabitsPerSecond(bitpersecond.PetabitsPerSecond).BitsPerSecond, PetabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromPetabytesPerSecond(bitpersecond.PetabytesPerSecond).BitsPerSecond, PetabytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromTebibitsPerSecond(bitpersecond.TebibitsPerSecond).BitsPerSecond, TebibitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromTebibytesPerSecond(bitpersecond.TebibytesPerSecond).BitsPerSecond, TebibytesPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromTerabitsPerSecond(bitpersecond.TerabitsPerSecond).BitsPerSecond, TerabitsPerSecondTolerance);
            AssertEx.EqualTolerance(1, BitRate.FromTerabytesPerSecond(bitpersecond.TerabytesPerSecond).BitsPerSecond, TerabytesPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            BitRate v = BitRate.FromBitsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (BitRate.FromBitsPerSecond(3)-v).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (BitRate.FromBitsPerSecond(10)/5).BitsPerSecond, BitsPerSecondTolerance);
            AssertEx.EqualTolerance(2, BitRate.FromBitsPerSecond(10)/BitRate.FromBitsPerSecond(5), BitsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            BitRate oneBitPerSecond = BitRate.FromBitsPerSecond(1);
            BitRate twoBitsPerSecond = BitRate.FromBitsPerSecond(2);

            Assert.True(oneBitPerSecond < twoBitsPerSecond);
            Assert.True(oneBitPerSecond <= twoBitsPerSecond);
            Assert.True(twoBitsPerSecond > oneBitPerSecond);
            Assert.True(twoBitsPerSecond >= oneBitPerSecond);

            Assert.False(oneBitPerSecond > twoBitsPerSecond);
            Assert.False(oneBitPerSecond >= twoBitsPerSecond);
            Assert.False(twoBitsPerSecond < oneBitPerSecond);
            Assert.False(twoBitsPerSecond <= oneBitPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            Assert.Equal(0, bitpersecond.CompareTo(bitpersecond));
            Assert.True(bitpersecond.CompareTo(BitRate.Zero) > 0);
            Assert.True(BitRate.Zero.CompareTo(bitpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            Assert.Throws<ArgumentException>(() => bitpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => bitpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = BitRate.FromBitsPerSecond(1);
            var b = BitRate.FromBitsPerSecond(2);

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
            var a = BitRate.FromBitsPerSecond(1);
            var b = BitRate.FromBitsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = BitRate.FromBitsPerSecond(1);
            Assert.True(v.Equals(BitRate.FromBitsPerSecond(1), BitsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(BitRate.Zero, BitsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            Assert.False(bitpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            BitRate bitpersecond = BitRate.FromBitsPerSecond(1);
            Assert.False(bitpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(BitRateUnit.Undefined, BitRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(BitRateUnit)).Cast<BitRateUnit>();
            foreach(var unit in units)
            {
                if(unit == BitRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(BitRate.BaseDimensions is null);
        }
    }
}
