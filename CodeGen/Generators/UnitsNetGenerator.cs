﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System.IO;
using System.Linq;
using System.Text;
using CodeGen.Generators.UnitsNetGen;
using CodeGen.JsonTypes;
using Serilog;

namespace CodeGen.Generators
{
    /// <summary>
    ///     Code generator for UnitsNet and UnitsNet.Tests projects.
    /// </summary>
    internal static class UnitsNetGenerator
    {
        private const int AlignPad = 35;

        /// <summary>
        ///     Generate source code for UnitsNet project for the given parsed quantities.
        ///     Outputs files relative to the given root dir to these locations:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>UnitsNet/GeneratedCode (quantity and unit types, Quantity, UnitAbbreviationCache)</description>
        ///         </item>
        ///         <item>
        ///             <description>UnitsNet.Tests/GeneratedCode (tests)</description>
        ///         </item>
        ///         <item>
        ///             <description>UnitsNet.Tests/CustomCode (test stubs, one for each quantity if not already created)</description>
        ///         </item>
        ///     </list>
        /// </summary>
        /// <param name="rootDir">Path to repository root directory.</param>
        /// <param name="quantities">The parsed quantities.</param>
        public static void Generate(string rootDir, Quantity[] quantities)
        {
            var outputDir = $"{rootDir}/UnitsNet/GeneratedCode";
            var extensionsOutputDir = $"{rootDir}/UnitsNet.NumberExtensions/GeneratedCode";
            var extensionsTestOutputDir = $"{rootDir}/UnitsNet.NumberExtensions.Tests/GeneratedCode";
            var testProjectDir = $"{rootDir}/UnitsNet.Tests";

            // Ensure output directories exist
            Directory.CreateDirectory($"{outputDir}/Quantities");
            Directory.CreateDirectory($"{outputDir}/Units");
            Directory.CreateDirectory($"{extensionsOutputDir}");
            Directory.CreateDirectory($"{extensionsTestOutputDir}");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode/TestsBase");
            Directory.CreateDirectory($"{testProjectDir}/GeneratedCode/QuantityTests");

            foreach (var quantity in quantities)
            {
                var sb = new StringBuilder($"{quantity.Name}:".PadRight(AlignPad));
                GenerateQuantity(sb, quantity, $"{outputDir}/Quantities/{quantity.Name}.g.cs");
                GenerateUnitType(sb, quantity, $"{outputDir}/Units/{quantity.Name}Unit.g.cs");
                GenerateNumberToExtensions(sb, quantity, $"{extensionsOutputDir}/NumberTo{quantity.Name}Extensions.g.cs");
                GenerateNumberToExtensionsTestClass(sb, quantity, $"{extensionsTestOutputDir}/NumberTo{quantity.Name}ExtensionsTest.g.cs");

                // Example: CustomCode/Quantities/LengthTests inherits GeneratedCode/TestsBase/LengthTestsBase
                // This way when new units are added to the quantity JSON definition, we auto-generate the new
                // conversion function tests that needs to be manually implemented by the developer to fix the compile error
                // so it cannot be forgotten.
                GenerateQuantityTestBaseClass(sb, quantity, $"{testProjectDir}/GeneratedCode/TestsBase/{quantity.Name}TestsBase.g.cs");
                GenerateQuantityTestClassIfNotExists(sb, quantity, $"{testProjectDir}/CustomCode/{quantity.Name}Tests.cs");

                Log.Information(sb.ToString());
            }

            GenerateIQuantityTests(quantities, $"{testProjectDir}/GeneratedCode/IQuantityTests.g.cs");

            Log.Information("");
            GenerateUnitAbbreviationsCache(quantities, $"{outputDir}/UnitAbbreviationsCache.g.cs");
            GenerateQuantityType(quantities, $"{outputDir}/QuantityType.g.cs");
            GenerateStaticQuantity(quantities, $"{outputDir}/Quantity.g.cs");
            GenerateUnitConverter(quantities, $"{outputDir}/UnitConverter.g.cs");

            var unitCount = quantities.SelectMany(q => q.Units).Count();
            Log.Information("");
            Log.Information($"Total of {unitCount} units and {quantities.Length} quantities.");
            Log.Information("");
        }

        private static void GenerateQuantityTestClassIfNotExists(StringBuilder sb, Quantity quantity, string filePath)
        {
            if (File.Exists(filePath))
            {
                sb.Append("test stub(skip) ");
                return;
            }

            var content = new UnitTestStubGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("test stub(OK) ");
        }

        private static void GenerateQuantity(StringBuilder sb, Quantity quantity, string filePath)
        {
            var content = new QuantityGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("quantity(OK) ");
        }

        private static void GenerateNumberToExtensions(StringBuilder sb, Quantity quantity, string filePath)
        {
            var content = new NumberExtensionsGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("number extensions(OK) ");
        }

        private static void GenerateNumberToExtensionsTestClass(StringBuilder sb, Quantity quantity, string filePath)
        {
            var content = new NumberExtensionsTestClassGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("number extensions tests(OK) ");
        }

        private static void GenerateUnitType(StringBuilder sb, Quantity quantity, string filePath)
        {
            var content = new UnitTypeGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("unit(OK) ");
        }

        private static void GenerateQuantityTestBaseClass(StringBuilder sb, Quantity quantity, string filePath)
        {
            var content = new UnitTestBaseClassGenerator(quantity).Generate();
            File.WriteAllText(filePath, content);
            sb.Append("test base(OK) ");
        }

        private static void GenerateIQuantityTests(Quantity[] quantities, string filePath)
        {
            var content = new IQuantityTestClassGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("IQuantityTests.g.cs: ".PadRight(AlignPad) + "(OK)");
        }

        private static void GenerateUnitAbbreviationsCache(Quantity[] quantities, string filePath)
        {
            var content = new UnitAbbreviationsCacheGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("UnitAbbreviationsCache.g.cs: ".PadRight(AlignPad) + "(OK)");
        }

        private static void GenerateQuantityType(Quantity[] quantities, string filePath)
        {
            var content = new QuantityTypeGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("QuantityType.g.cs: ".PadRight(AlignPad) + "(OK)");
        }

        private static void GenerateStaticQuantity(Quantity[] quantities, string filePath)
        {
            var content = new StaticQuantityGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("Quantity.g.cs: ".PadRight(AlignPad) + "(OK)");
        }

        private static void GenerateUnitConverter(Quantity[] quantities, string filePath)
        {
            var content = new UnitConverterGenerator(quantities).Generate();
            File.WriteAllText(filePath, content);
            Log.Information("UnitConverter.g.cs: ".PadRight(AlignPad) + "(OK)");
        }
    }
}
