using System;
using PacktLibrary.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main()
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            var baby1 = mary.ProcreateWith(harry);
            var baby2 = Person.Procreate(harry, jill);

            System.Console.WriteLine($"{harry.Name} has {harry.Children.Count} children");
            System.Console.WriteLine($"{jill.Name} has {jill.Children.Count} children");
            System.Console.WriteLine($"{mary.Name} has {mary.Children.Count} children");

            System.Console.WriteLine(String.Format("{0}'s first child os named \"{1}\".", harry.Name, harry.Children[0].Name));

            var baby3 = harry * mary;
            System.Console.WriteLine(baby3.Name);

            System.Console.WriteLine($"5! is {Person.Factorial(5)}");
        }
    }
}
