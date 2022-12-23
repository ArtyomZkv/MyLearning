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
        }
    }
}

