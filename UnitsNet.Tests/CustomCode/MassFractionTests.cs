﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
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
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MassFractionTests : MassFractionTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        #region Unit Conversion Coefficients
        protected override double KilogramsPerKilogramInOneDecimalFraction => 1;
        protected override double HectogramsPerKilogramInOneDecimalFraction => 10;
        protected override double DecagramsPerKilogramInOneDecimalFraction => 1E2;
        protected override double GramsPerKilogramInOneDecimalFraction => 1E3;
        protected override double DecigramsPerKilogramInOneDecimalFraction => 1E4;
        protected override double CentigramsPerKilogramInOneDecimalFraction => 1E5;
        protected override double MilligramsPerKilogramInOneDecimalFraction => 1E6;
        protected override double MicrogramsPerKilogramInOneDecimalFraction => 1E9;
        protected override double NanogramsPerKilogramInOneDecimalFraction => 1E12;

        protected override double KilogramsPerGramInOneDecimalFraction => 1E-3;
        protected override double HectogramsPerGramInOneDecimalFraction => 1E-2;
        protected override double DecagramsPerGramInOneDecimalFraction => 1E-1;
        protected override double GramsPerGramInOneDecimalFraction => 1;
        protected override double DecigramsPerGramInOneDecimalFraction => 10;
        protected override double CentigramsPerGramInOneDecimalFraction => 1E2;
        protected override double MilligramsPerGramInOneDecimalFraction => 1E3;
        protected override double MicrogramsPerGramInOneDecimalFraction => 1E6;
        protected override double NanogramsPerGramInOneDecimalFraction => 1E9;

        protected override double PartsPerThousandInOneDecimalFraction => 1e3;
        protected override double PartsPerMillionInOneDecimalFraction => 1e6;
        protected override double PartsPerBillionInOneDecimalFraction => 1e9;
        protected override double PartsPerTrillionInOneDecimalFraction => 1e12;

        protected override double DecimalFractionsInOneDecimalFraction => 1;
        protected override double PercentInOneDecimalFraction => 100;
        #endregion

        [Fact]
        public void MassFractionFromMassesConstructedCorrectly()
        {
            var one_kg = Mass.FromKilograms(1);
            var two_kg = Mass.FromKilograms(2);

            var massFraction = MassFraction.FromMasses(one_kg, two_kg);

            AssertEx.EqualTolerance(50, massFraction.Percent, PercentTolerance);
        }

        [Fact]
        public void TotalMassFromMassFraction()
        {
            var componentMass = Mass.FromKilograms(1);
            var massFraction = MassFraction.FromPercent(50);

            var totalMass = massFraction.GetTotalMass(componentMass);

            AssertEx.EqualTolerance(2, totalMass.Kilograms, KilogramsPerKilogramTolerance);
        }

        [Fact]
        public void ComponentMassFromMassFraction()
        {
            var totalMass = Mass.FromKilograms(2);
            var massFraction = MassFraction.FromPercent(50);

            var componentMass = massFraction.GetComponentMass(totalMass);

            AssertEx.EqualTolerance(1, componentMass.Kilograms, KilogramsPerKilogramTolerance);
        }

    }
}
