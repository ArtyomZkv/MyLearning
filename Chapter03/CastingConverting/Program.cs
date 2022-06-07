using System;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            System.Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            System.Console.WriteLine(d);

            long e = 10;
            int f = (int)e;
            System.Console.WriteLine($"e is {e}, and f is {f:N0}");

            e = 5_000_000_020;
            f = (int)e;
            int m = int.MaxValue;
            System.Console.WriteLine($"e is {e}, and f is {f:N0}, m = {m:N3}");

            double g = 9.8;
            int n = Convert.ToInt32(g);
            System.Console.WriteLine($"g is {g} and n is {n:N0}");

            double[] doubles = new[]
            { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double h in doubles)
            {
                System.Console.WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}", 
                    arg0: n,
                    arg1: Math.Round(value: n,
                    digits: 0,
                    mode: MidpointRounding.AwayFromZero));
            }
            byte[] binaryObject = new byte[128];

            new Random().NextBytes(binaryObject);
            System.Console.WriteLine("Binary object as bytes:");

            for (int i = 0; i < binaryObject.Length; i++)
            {
                System.Console.Write($"{binaryObject[i]} ");
            }
            System.Console.WriteLine();

            string encoded = Convert.ToBase64String(binaryObject);
            System.Console.WriteLine($"Binary Object as Base64: {encoded}");

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            System.Console.WriteLine($"I was borned {age} ago");
            System.Console.WriteLine($"My birthday is {birthday}.");
            System.Console.WriteLine($"My birthday is {birthday:D}.");

            System.Console.Write("How mane eggs are there? ");
            int count;
            string input = Console.ReadLine();

            if (int.TryParse(input, out count))
            {
                System.Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                System.Console.WriteLine("I could not parse the input");
            }
        }
    }
}
