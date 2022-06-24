using PrimeNumbersLib;
using System;

namespace PrimeNumbersApp
{
    class Program
    {
        static void Main()
        {
            var PrimeNumbers = new PrimeNumbers();
            Console.WriteLine(PrimeNumbers.GetPrimeNumbers(7));
        }
    }
}

