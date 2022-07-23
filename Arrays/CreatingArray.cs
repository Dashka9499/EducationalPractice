using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            return new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            return new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            return new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            return new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            return new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            return new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            return new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            return new int[] { 123_456 };
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            return new int[] { 1_111_111, 9_999_999 };
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            return new int[] { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            return new bool[] { true };
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            return new bool[] { true, false, true, false, true };
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            return new bool[] { false, true, true, false, true, true, false };
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            return new string[] { "one" };
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            return new string[] { "one", "two", "three" };
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            return new string[] { "one", "two", "three", "four", "five", "six" };
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            return new char[] { 'a' };
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            return new char[] { 'a', 'b', 'c' };
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            return new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            return new double[] { 1.12 };
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            return new double[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
        }

        public static double[] CreateDoubleWithNineElements()
        {
            return new double[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            return new float[] { 123_456_789.123_456f };
        }

        public static float[] CreateFloatWithThreeElements()
        {
            return new float[] { 1_000_000.123_456f, 2_223_334_444.123_456f, 9_999.999_999f };
        }

        public static float[] CreateFloatWithFiveElements()
        {
            return new float[] { 1.012_3f, 20.012_345f, 300.012_345_67f, 4_000.0123_456_7f, 500_000.012_345_67f };
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            return new decimal[] { 10_000.123456M };
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            return new decimal[] { 1_000.1234M, 100_000.2345M, 100_000.3456M, 1_000_000.456789M, 10_000_000.5678901M };
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            return new decimal[] { 10.122112M, 200.233223M, 3_000.344334M, 40_000.455445M, 500_000.566556M, 6_000_000.677667M, 70_000_000.788778M, 800_000_000.899889M, 9_000_000_000.911991M };
        }
    }
}
