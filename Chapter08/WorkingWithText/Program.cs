using System;

namespace WorkWithText
{
    class Propgram
    {
        static void Main()
        {
            string city = "London";
            System.Console.WriteLine($"{city} is {city.Length} characters long. ");

            System.Console.WriteLine($"First char is {city[0]} and third is {city[2]}. ");

            string cities = "Paris,Berlin,Madrid,New York";

            string[] citiesArray = cities.Split(',');

            foreach (var item in citiesArray)
            {
                System.Console.WriteLine(item);
            }

            string fullName = "Alan Jones";

            int indexOfTheSpace = fullName.IndexOf(' ');

            string firstName = fullName.Substring(0, indexOfTheSpace);

            string lastName = fullName.Substring(indexOfTheSpace+1);

            System.Console.WriteLine($"{lastName}, {firstName}");


            string fullName2 = "Jones, Alan";

            int indexOfTheSpace2 = fullName2.IndexOf(' ');

            string firstName2 = fullName2.Substring(indexOfTheSpace2+1);

            string lastName2 = fullName2.Substring(0, indexOfTheSpace2-1);

            System.Console.WriteLine(fullName2);

            string company = "Microsoft";

            bool startsWithM = company.StartsWith("M");

            bool containsN = company.Contains("N");

            System.Console.WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

        }
    }
}

