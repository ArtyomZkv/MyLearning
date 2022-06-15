using System;

namespace Debugging
{
    class Program
    {
        /// <summary>
        /// Возвращает произведение чисел а и b
        /// </summary>
        /// <param name="a"> параметр а</param>
        /// <param name="b"> параметр b</param>
        /// <returns>число типа double</returns>
        static double Add(double a, double b)
        {
            return a * b;
        }
        static void Main()
        {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a, b);
            System.Console.WriteLine($"{a} * {b} = {answer}");
            Console.ReadLine();
        }
    }
}
