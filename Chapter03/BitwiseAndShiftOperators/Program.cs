using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); // только столбец 2-го бита
            WriteLine($"a | b = {a | b}"); // столбцы 8, 4 и 2-го битов
            WriteLine($"a ^ b = {a ^ b}"); // столбцы 8-го и 4-го битов
        }
    }
}
