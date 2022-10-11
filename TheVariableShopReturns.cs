namespace Players_Guide_Tasks
{
    internal static class TheVariableShopReturns
    {
        internal static void Run()
        {
            // ## Challenge: The variable shop returns (50XP)
            // Declare variables and initialize them with values
            byte byteVar = byte.MaxValue;
            short shortVar = short.MaxValue;
            int intVar = int.MaxValue;
            long longVar = long.MaxValue;
            sbyte sByteVar = sbyte.MaxValue;
            ushort uShortVar = ushort.MaxValue;
            uint uIntVar = uint.MaxValue;
            ulong uLongVar = ulong.MaxValue;
            float floatVar = float.MaxValue;
            double doubleVar = double.MaxValue;
            decimal decimalVar = decimal.MaxValue;
            char charVar = 'A';
            bool boolVar = true;
            string stringVar = "hello";

            // Print the values to the console
            PrintVariables();

            // Change the values of the variables
            byteVar = 128;
            shortVar = 25000;
            intVar = 2000000;
            longVar = -3_333_333_333L;
            sByteVar = -128;
            uShortVar = 65000;
            uIntVar = 3_000_000_000;
            uLongVar = 4_000_000_000_000_000UL;
            floatVar = 1.27F;
            doubleVar = -0.0667D;
            decimalVar = 0.00000029M;
            charVar = 'Z';
            boolVar = false;
            stringVar = "world";

            // Print the updated values to the console
            Console.Clear();
            PrintVariables();

            void PrintVariables()
            {
                // Print the result to the console
                Console.WriteLine($"Byte: {byteVar}");
                Console.WriteLine($"Short: {shortVar}");
                Console.WriteLine($"Int: {intVar}");
                Console.WriteLine($"Long: {longVar}");
                Console.WriteLine($"Signed Byte: {sByteVar}");
                Console.WriteLine($"Unsigned Short: {uShortVar}");
                Console.WriteLine($"Unsigned Int: {uIntVar}");
                Console.WriteLine($"Unsigned Long: {uLongVar}");
                Console.WriteLine($"Float: {floatVar}");
                Console.WriteLine($"Double: {doubleVar}");
                Console.WriteLine($"Decimal: {decimalVar}");
                Console.WriteLine($"Char: {charVar}");
                Console.WriteLine($"Bool: {boolVar}");
                Console.WriteLine($"String: {stringVar}");

                Console.ReadKey(true); // Wait for the user to aknowledge
            }
        }
    }
}