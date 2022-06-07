using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Before parsing");
            System.Console.Write("What is your age? ");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                System.Console.WriteLine($"You are {age} years old.");
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            catch
            {
                System.Console.WriteLine("The age you entered is not a valid number format");
            }
            System.Console.WriteLine("After parsing");
        }
    }
}
