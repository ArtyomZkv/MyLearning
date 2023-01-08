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

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            
            MatchCollection filmsSmart = csv.Matches(films);
            
            Console.WriteLine("Smart attempt at splitting:");
            
            foreach (Match film in filmsSmart)
            {
                Console.WriteLine(film.Groups[2].Value);
            }



        }
    }
}

