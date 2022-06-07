using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main()
        {
            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();

            WriteLine();
            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, {key.Modifiers}");

            int numbersOfApples = 12;
            decimal pricePerApple = 0.35M;

            WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numbersOfApples,
                arg1: pricePerApple * numbersOfApples);

            string formatted = string.Format(
                format: "{0} apples cost {1:C}",
                arg0: numbersOfApples,
                arg1: pricePerApple * numbersOfApples);

            WriteLine($"{numbersOfApples} apples cost {pricePerApple * numbersOfApples:C}");
            WriteLine(formatted);
        }
    }
}
