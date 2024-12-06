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

using UnitsNet.NumberExtensions.NumberToKinematicViscosity;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToKinematicViscosityExtensionsTests
    {
        [Fact]
        public void NumberToCentistokesTest() =>
            Assert.Equal(KinematicViscosity.FromCentistokes(2), 2.Centistokes());

        [Fact]
        public void NumberToDecistokesTest() =>
            Assert.Equal(KinematicViscosity.FromDecistokes(2), 2.Decistokes());

        [Fact]
        public void NumberToKilostokesTest() =>
            Assert.Equal(KinematicViscosity.FromKilostokes(2), 2.Kilostokes());

        [Fact]
        public void NumberToMicrostokesTest() =>
            Assert.Equal(KinematicViscosity.FromMicrostokes(2), 2.Microstokes());

        [Fact]
        public void NumberToMillistokesTest() =>
            Assert.Equal(KinematicViscosity.FromMillistokes(2), 2.Millistokes());

        [Fact]
        public void NumberToNanostokesTest() =>
            Assert.Equal(KinematicViscosity.FromNanostokes(2), 2.Nanostokes());

        [Fact]
        public void NumberToSquareFeetPerSecondTest() =>
            Assert.Equal(KinematicViscosity.FromSquareFeetPerSecond(2), 2.SquareFeetPerSecond());

        [Fact]
        public void NumberToSquareMetersPerSecondTest() =>
            Assert.Equal(KinematicViscosity.FromSquareMetersPerSecond(2), 2.SquareMetersPerSecond());

        [Fact]
        public void NumberToStokesTest() =>
            Assert.Equal(KinematicViscosity.FromStokes(2), 2.Stokes());

    }
}
