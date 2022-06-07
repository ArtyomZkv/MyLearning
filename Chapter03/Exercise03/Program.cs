using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 1; i <= 100; i ++)
            {
                if ( i % 15 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if ( i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else if ( i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else 
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
