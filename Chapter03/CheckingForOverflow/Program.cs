using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    System.Console.WriteLine($"Initial value: {x}");
                    for (int i = 0; i < 3; i++)
                    {
                        x++;
                        System.Console.WriteLine($"After incrementing: {x}");
                    }
                }
            }
            catch(OverflowException)
            {
                System.Console.WriteLine("The code overflowed but i caught the exception.");
            }

                unchecked
                {
                    int y = int.MaxValue + 1;
                    System.Console.WriteLine($"Initial value: {y}");
                    for (int i = 0; i < 2; i++)
                    {
                        y--;
                        System.Console.WriteLine($"After decrementing: {y}");
                    }
                }
        }
    }
}
