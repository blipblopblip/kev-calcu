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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToCapacitance
{
    /// <summary>
    /// A number to Capacitance Extensions
    /// </summary>
    public static class NumberToCapacitanceExtensions
    {
        /// <inheritdoc cref="Capacitance.FromFarads(UnitsNet.QuantityValue)" />
        public static Capacitance Farads<T>(this T value) =>
            Capacitance.FromFarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromKilofarads(UnitsNet.QuantityValue)" />
        public static Capacitance Kilofarads<T>(this T value) =>
            Capacitance.FromKilofarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromMegafarads(UnitsNet.QuantityValue)" />
        public static Capacitance Megafarads<T>(this T value) =>
            Capacitance.FromMegafarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromMicrofarads(UnitsNet.QuantityValue)" />
        public static Capacitance Microfarads<T>(this T value) =>
            Capacitance.FromMicrofarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromMillifarads(UnitsNet.QuantityValue)" />
        public static Capacitance Millifarads<T>(this T value) =>
            Capacitance.FromMillifarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromNanofarads(UnitsNet.QuantityValue)" />
        public static Capacitance Nanofarads<T>(this T value) =>
            Capacitance.FromNanofarads(Convert.ToDouble(value));

        /// <inheritdoc cref="Capacitance.FromPicofarads(UnitsNet.QuantityValue)" />
        public static Capacitance Picofarads<T>(this T value) =>
            Capacitance.FromPicofarads(Convert.ToDouble(value));

    }
}
