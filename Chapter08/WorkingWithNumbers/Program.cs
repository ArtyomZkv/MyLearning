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
        }
    }
}

