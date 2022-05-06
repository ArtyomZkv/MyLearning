using System;

namespace Formatting
{
    class Program
    {
        static void Main()
        {
            int numbersOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numbersOfApples,
                arg1: pricePerApple * numbersOfApples);

            string formatted = string.Format(
                format: "{0} apples cost {1:C}",
                arg0: numbersOfApples,
                arg1: pricePerApple * numbersOfApples);

            Console.WriteLine($"{numbersOfApples} apples cost {pricePerApple * numbersOfApples:C}");
            Console.WriteLine(formatted);
        }
    }
}
