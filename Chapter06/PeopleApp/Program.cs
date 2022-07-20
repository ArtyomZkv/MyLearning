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

            harry.Shout += Harry_Shout;

            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people =
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard"}
            };
            
            System.Console.WriteLine("Initial list of people:");
            
            foreach (var person in people)
            {
                System.Console.WriteLine($"{person.Name}");
            }
            
            System.Console.WriteLine("Use Person's IComparable implementation to sort.");
            Array.Sort(people);
            foreach (var person in people)
            {
                System.Console.WriteLine($"{person.Name}");
            }

            System.Console.WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                System.Console.WriteLine($"{person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            System.Console.WriteLine($"Thing with an integer: {t1.Process("42")}");

            var t2 = new Thing();
            t2.Data = "apple";
            System.Console.WriteLine($"Thing with a string: {t2.Process("apple")}");
        }
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            System.Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
            System.Console.WriteLine($"{p.GetType()}, {sender.GetType()}");
        }
        
    }
}
