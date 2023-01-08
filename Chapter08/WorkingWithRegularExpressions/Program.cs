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

            var ageChecker = new Regex(@"^\d+$");

            if (ageChecker.IsMatch(input))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                System.Console.WriteLine($"This is not a valid age: {input}");
            }

            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

            string[] filmsDumb = films.Split(',');

            System.Console.WriteLine("Dumb attempt at splitting:");
            foreach (string film in filmsDumb)
            {
                System.Console.WriteLine(film);
            }

            
        }
    }
}

