using System.Numerics;

namespace WorkWithNubmers
{
    class Propgram
    {
         static void Main()
         {
            var largest = ulong.MaxValue;
            System.Console.WriteLine($"{largest, 40:N0}");

            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            System.Console.WriteLine($"{atomsInTheUniverse, 40:N0}");

            var c1 = new Complex(4, 2);
            var c2 = new Complex(3, 7);
            var c3 = c1 + c2;

            System.Console.WriteLine($"{c1} added to {c2} is {c3}");

            


        }
    }
}

