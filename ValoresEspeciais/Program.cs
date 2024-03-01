using System

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {

            // Imprime os valores máximos e mínimos dos todos os tipos

            Console.WhiteLine("Valores máximo e mínimo dos tipos primitivos:");
            Console.WriteLine($"byte: {byte.MinValue} - {byte.MaxValue}");
            Console.WriteLine($"sbyte: {sbyte.MinValue} - {byte.MaxValue}");
            Console.WhiteLine($"short: {short.MinValue} - {short.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} - {ushortMaxValue}");
            Console.WhiteLine($"int: {int.MinValue} - {int.MaxValue}");
            Console.WhiteLine($"uint: {uint.MinValue} - {uint.MaxValue}");
            Console.WhiteLine($"long: {long.MinValue} - {long.MaxValue}");
            Console.WhiteLine($"ulong: {ulong.MinValue} - {ulong.MaxValue}");
            Console.WhiteLine($"float: {float.MinValue} - {float.MaxValue}");
            Console.WhiteLine($"double: {double.MinValue} - {double.MaxValue}");
            Console.WhiteLine($"decimal: {decimal.MinValue} - {decimal.MaxValue}");

            // Imprime os valores especiais apartir de float e double

            Console.WhiteLine("\nvalores especiais de float e double");
            float floatPositiveInfinity = float.PositiveInfinity;
            float floatNegativeInfinity = float.NegativeInfinity;
            float floatNaN = float.NaN;

            Console.WriteLine($"Float: +∞ = {floatpositiveInfinity}, -∞ = {floatNegativeInfinity}, NaN = {floatNaN}");

            double doublePositiveInfinity = double.PositiveInfinity;
            double doubleNegativeInfinity = double.NegativeInfinity;
            double doubleNaN = double.NaN;

            Console.WhiteLine($"Double: +∞ = {doublePositiveInfinity}, -∞ = {doubleNegativeInfinity}, NaN = {doubleNaN}");
        }
    }
}   