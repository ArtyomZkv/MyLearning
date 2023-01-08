using System;
using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();

            var ageChecker = new Regex(@"\d");

            if (ageChecker.IsMatch(input))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                System.Console.WriteLine($"This is not a valid age: {input}");
            }
        }
    }
}

