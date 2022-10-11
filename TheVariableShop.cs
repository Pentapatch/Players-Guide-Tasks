namespace Players_Guide_Tasks
{
    internal static class TheVariableShop
    {
        internal static void Run()
        {
            // ## Challenge: The variable shop (100XP)

            // Declare variables and initialize them with corresponing values
            byte byteVar = byte.MaxValue;          // or 255    - there are no suffix for byte!
            short shortVar = short.MaxValue;       // or -12    - there are no suffix for short!
            int intVar = int.MaxValue;             // or 2022   - there are no suffix for int!
            long longVar = long.MaxValue;          // or 84L    - where the "L" suffix stands for "long"
            sbyte sByteVar = sbyte.MaxValue;       // or -128   - there is no suffix for the byte type!
            ushort uShortVar = ushort.MaxValue;    // or 12     - there is no suffix for the short type!
            uint uIntVar = uint.MaxValue;          // or 32U    - where the "U" suffix stands for "unsigned"
            ulong uLongVar = ulong.MaxValue;       // or 52UL   - where the "U" suffix stands for "unsigned" and "L" for "long"
            float floatVar = float.MaxValue;       // or 3.621F - where the "F" suffix stands for "float", leave it out to assign a double (if a decimal place is provided - otherwise it will be treated as an int)
            double doubleVar = double.MaxValue;    // or 32D    - where the "D" suffix stands for "double"
            decimal decimalVar = decimal.MaxValue; // or 0.073M - where the "M" suffix stands for "monetary" (think money, where the accuracy of a decimal type might be needed)
            char charVar = 'A';                    // Note the single quatation marks here
            bool boolVar = true;
            string stringVar = "hello";

            // Print the variables to the console
            Console.WriteLine($"Byte: {byte.MinValue} to {byteVar}");
            Console.WriteLine($"Short: {short.MinValue} to {shortVar}");
            Console.WriteLine($"Int: {int.MinValue} to {intVar}");
            Console.WriteLine($"Long: {long.MinValue} to {longVar}");
            Console.WriteLine($"Signed Byte: {sbyte.MinValue} to {sByteVar}");
            Console.WriteLine($"Unsigned Short: {ushort.MinValue} to {uShortVar}");
            Console.WriteLine($"Unsigned Int: {uint.MinValue} to {uIntVar}");
            Console.WriteLine($"Unsigned Long: {ulong.MinValue} to {uLongVar}");
            Console.WriteLine($"Float: {float.MinValue} to {floatVar}");
            Console.WriteLine($"Double: {double.MinValue} to {doubleVar}");
            Console.WriteLine($"Decimal: {decimal.MinValue} to {decimalVar}");
            Console.WriteLine($"Char: {charVar}");
            Console.WriteLine($"Bool: {false} or {boolVar}");
            Console.WriteLine($"String: {stringVar}");
            Console.ReadKey();
        }
    }
}