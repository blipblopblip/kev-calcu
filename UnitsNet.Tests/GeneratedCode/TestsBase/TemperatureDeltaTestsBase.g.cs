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
    /// Test of TemperatureDelta.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureDeltaTestsBase : QuantityTestsBase
    {
        protected abstract double DegreesCelsiusInOneKelvin { get; }
        protected abstract double DegreesDelisleInOneKelvin { get; }
        protected abstract double DegreesFahrenheitInOneKelvin { get; }
        protected abstract double DegreesNewtonInOneKelvin { get; }
        protected abstract double DegreesRankineInOneKelvin { get; }
        protected abstract double DegreesReaumurInOneKelvin { get; }
        protected abstract double DegreesRoemerInOneKelvin { get; }
        protected abstract double KelvinsInOneKelvin { get; }
        protected abstract double MillidegreesCelsiusInOneKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelsiusTolerance { get { return 1e-5; } }
        protected virtual double DegreesDelisleTolerance { get { return 1e-5; } }
        protected virtual double DegreesFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double DegreesNewtonTolerance { get { return 1e-5; } }
        protected virtual double DegreesRankineTolerance { get { return 1e-5; } }
        protected virtual double DegreesReaumurTolerance { get { return 1e-5; } }
        protected virtual double DegreesRoemerTolerance { get { return 1e-5; } }
        protected virtual double KelvinsTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesCelsiusTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta((double)0.0, TemperatureDeltaUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new TemperatureDelta();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(TemperatureDeltaUnit.Kelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.PositiveInfinity, TemperatureDeltaUnit.Kelvin));
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.NegativeInfinity, TemperatureDeltaUnit.Kelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.NaN, TemperatureDeltaUnit.Kelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new TemperatureDelta(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new TemperatureDelta(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (TemperatureDelta) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void TemperatureDelta_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new TemperatureDelta(1, TemperatureDeltaUnit.Kelvin);

            QuantityInfo<TemperatureDeltaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(TemperatureDelta.Zero, quantityInfo.Zero);
            Assert.Equal("TemperatureDelta", quantityInfo.Name);
            Assert.Equal(QuantityType.TemperatureDelta, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<TemperatureDeltaUnit>().Except(new[] {TemperatureDeltaUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void KelvinToTemperatureDeltaUnits()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, kelvin.MillidegreesCelsius, MillidegreesCelsiusTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeCelsius);
            AssertEx.EqualTolerance(1, quantity00.DegreesCelsius, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeCelsius, quantity00.Unit);

            var quantity01 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeDelisle);
            AssertEx.EqualTolerance(1, quantity01.DegreesDelisle, DegreesDelisleTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeDelisle, quantity01.Unit);

            var quantity02 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(1, quantity02.DegreesFahrenheit, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeFahrenheit, quantity02.Unit);

            var quantity03 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeNewton);
            AssertEx.EqualTolerance(1, quantity03.DegreesNewton, DegreesNewtonTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeNewton, quantity03.Unit);

            var quantity04 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeRankine);
            AssertEx.EqualTolerance(1, quantity04.DegreesRankine, DegreesRankineTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRankine, quantity04.Unit);

            var quantity05 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeReaumur);
            AssertEx.EqualTolerance(1, quantity05.DegreesReaumur, DegreesReaumurTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeReaumur, quantity05.Unit);

            var quantity06 = TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeRoemer);
            AssertEx.EqualTolerance(1, quantity06.DegreesRoemer, DegreesRoemerTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRoemer, quantity06.Unit);

            var quantity07 = TemperatureDelta.From(1, TemperatureDeltaUnit.Kelvin);
            AssertEx.EqualTolerance(1, quantity07.Kelvins, KelvinsTolerance);
            Assert.Equal(TemperatureDeltaUnit.Kelvin, quantity07.Unit);

            var quantity08 = TemperatureDelta.From(1, TemperatureDeltaUnit.MillidegreeCelsius);
            AssertEx.EqualTolerance(1, quantity08.MillidegreesCelsius, MillidegreesCelsiusTolerance);
            Assert.Equal(TemperatureDeltaUnit.MillidegreeCelsius, quantity08.Unit);

        }

        [Fact]
        public void FromKelvins_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.NegativeInfinity));
        }

        [Fact]
        public void FromKelvins_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeCelsius), DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeDelisle), DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeFahrenheit), DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeNewton), DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeRankine), DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeReaumur), DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeRoemer), DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.As(TemperatureDeltaUnit.Kelvin), KelvinsTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, kelvin.As(TemperatureDeltaUnit.MillidegreeCelsius), MillidegreesCelsiusTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new TemperatureDelta(value: 1, unit: TemperatureDelta.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var kelvin = TemperatureDelta.FromKelvins(1);

            var degreecelsiusQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeCelsius);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, (double)degreecelsiusQuantity.Value, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeCelsius, degreecelsiusQuantity.Unit);

            var degreedelisleQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeDelisle);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, (double)degreedelisleQuantity.Value, DegreesDelisleTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeDelisle, degreedelisleQuantity.Unit);

            var degreefahrenheitQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, (double)degreefahrenheitQuantity.Value, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeFahrenheit, degreefahrenheitQuantity.Unit);

            var degreenewtonQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeNewton);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, (double)degreenewtonQuantity.Value, DegreesNewtonTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeNewton, degreenewtonQuantity.Unit);

            var degreerankineQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeRankine);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, (double)degreerankineQuantity.Value, DegreesRankineTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRankine, degreerankineQuantity.Unit);

            var degreereaumurQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeReaumur);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, (double)degreereaumurQuantity.Value, DegreesReaumurTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeReaumur, degreereaumurQuantity.Unit);

            var degreeroemerQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeRoemer);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, (double)degreeroemerQuantity.Value, DegreesRoemerTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRoemer, degreeroemerQuantity.Unit);

            var kelvinQuantity = kelvin.ToUnit(TemperatureDeltaUnit.Kelvin);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, (double)kelvinQuantity.Value, KelvinsTolerance);
            Assert.Equal(TemperatureDeltaUnit.Kelvin, kelvinQuantity.Unit);

            var millidegreecelsiusQuantity = kelvin.ToUnit(TemperatureDeltaUnit.MillidegreeCelsius);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, (double)millidegreecelsiusQuantity.Value, MillidegreesCelsiusTolerance);
            Assert.Equal(TemperatureDeltaUnit.MillidegreeCelsius, millidegreecelsiusQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = TemperatureDelta.FromKelvins(1).ToBaseUnit();
            Assert.Equal(TemperatureDelta.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesCelsius(kelvin.DegreesCelsius).Kelvins, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesDelisle(kelvin.DegreesDelisle).Kelvins, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesFahrenheit(kelvin.DegreesFahrenheit).Kelvins, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesNewton(kelvin.DegreesNewton).Kelvins, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesRankine(kelvin.DegreesRankine).Kelvins, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesReaumur(kelvin.DegreesReaumur).Kelvins, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesRoemer(kelvin.DegreesRoemer).Kelvins, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromKelvins(kelvin.Kelvins).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromMillidegreesCelsius(kelvin.MillidegreesCelsius).Kelvins, MillidegreesCelsiusTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TemperatureDelta v = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(-1, -v.Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureDelta.FromKelvins(3)-v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureDelta.FromKelvins(10)/5).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, TemperatureDelta.FromKelvins(10)/TemperatureDelta.FromKelvins(5), KelvinsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TemperatureDelta oneKelvin = TemperatureDelta.FromKelvins(1);
            TemperatureDelta twoKelvins = TemperatureDelta.FromKelvins(2);

            Assert.True(oneKelvin < twoKelvins);
            Assert.True(oneKelvin <= twoKelvins);
            Assert.True(twoKelvins > oneKelvin);
            Assert.True(twoKelvins >= oneKelvin);

            Assert.False(oneKelvin > twoKelvins);
            Assert.False(oneKelvin >= twoKelvins);
            Assert.False(twoKelvins < oneKelvin);
            Assert.False(twoKelvins <= oneKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Equal(0, kelvin.CompareTo(kelvin));
            Assert.True(kelvin.CompareTo(TemperatureDelta.Zero) > 0);
            Assert.True(TemperatureDelta.Zero.CompareTo(kelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Throws<ArgumentException>(() => kelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Throws<ArgumentNullException>(() => kelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = TemperatureDelta.FromKelvins(1);
            var b = TemperatureDelta.FromKelvins(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = TemperatureDelta.FromKelvins(1);
            var b = TemperatureDelta.FromKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = TemperatureDelta.FromKelvins(1);
            object b = TemperatureDelta.FromKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = TemperatureDelta.FromKelvins(1);
            Assert.True(v.Equals(TemperatureDelta.FromKelvins(1), KelvinsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TemperatureDelta.Zero, KelvinsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = TemperatureDelta.FromKelvins(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(TemperatureDelta.FromKelvins(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.False(kelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.False(kelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureDeltaUnit.Undefined, TemperatureDelta.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureDeltaUnit)).Cast<TemperatureDeltaUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureDeltaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(TemperatureDelta.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 ∆°C", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeCelsius).ToString());
                Assert.Equal("1 ∆°De", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeDelisle).ToString());
                Assert.Equal("1 ∆°F", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeFahrenheit).ToString());
                Assert.Equal("1 ∆°N", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeNewton).ToString());
                Assert.Equal("1 ∆°R", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeRankine).ToString());
                Assert.Equal("1 ∆°Ré", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeReaumur).ToString());
                Assert.Equal("1 ∆°Rø", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeRoemer).ToString());
                Assert.Equal("1 ∆K", new TemperatureDelta(1, TemperatureDeltaUnit.Kelvin).ToString());
                Assert.Equal("1 ∆m°C", new TemperatureDelta(1, TemperatureDeltaUnit.MillidegreeCelsius).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 ∆°C", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 ∆°De", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeDelisle).ToString(swedishCulture));
            Assert.Equal("1 ∆°F", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeFahrenheit).ToString(swedishCulture));
            Assert.Equal("1 ∆°N", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeNewton).ToString(swedishCulture));
            Assert.Equal("1 ∆°R", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeRankine).ToString(swedishCulture));
            Assert.Equal("1 ∆°Ré", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeReaumur).ToString(swedishCulture));
            Assert.Equal("1 ∆°Rø", new TemperatureDelta(1, TemperatureDeltaUnit.DegreeRoemer).ToString(swedishCulture));
            Assert.Equal("1 ∆K", new TemperatureDelta(1, TemperatureDeltaUnit.Kelvin).ToString(swedishCulture));
            Assert.Equal("1 ∆m°C", new TemperatureDelta(1, TemperatureDeltaUnit.MillidegreeCelsius).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s1"));
                Assert.Equal("0.12 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s2"));
                Assert.Equal("0.123 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s3"));
                Assert.Equal("0.1235 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s1", culture));
            Assert.Equal("0.12 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s2", culture));
            Assert.Equal("0.123 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s3", culture));
            Assert.Equal("0.1235 ∆K", new TemperatureDelta(0.123456, TemperatureDeltaUnit.Kelvin).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(TemperatureDelta)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(TemperatureDeltaUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(QuantityType.TemperatureDelta, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(TemperatureDelta.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(TemperatureDelta.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = TemperatureDelta.FromKelvins(1.0);
            Assert.Equal(new {TemperatureDelta.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = TemperatureDelta.FromKelvins(value);
            Assert.Equal(TemperatureDelta.FromKelvins(-value), -quantity);
        }
    }
}
