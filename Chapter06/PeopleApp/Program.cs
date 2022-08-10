using System;
using PacktLibrary.Shared;

namespace PacktLibrary
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

            //harry.Shout += Harry_Shout;

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

            var t1 = new Thing
            {
                Data = 42
            };
            System.Console.WriteLine($"Thing with an integer: {t1.Process("42")}");

            var t2 = new Thing
            {
                Data = "apple"
            };
            System.Console.WriteLine($"Thing with a string: {t2.Process("apple")}");

            var gt1 = new GenericThing<int>
            {
                Data = 42
            };
            Console.WriteLine($"GenericThing with an integer:{gt1.Process(42)}");

            var gt2 = new GenericThing<string>
            {
                Data = "apple"
            };
            Console.WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            string number1 = "4";
            System.Console.WriteLine("{0} sqared is {1}", number1, Squarer.Square<string>(number1));

            byte number2 = 3;
            System.Console.WriteLine("{0} squared is {1}", number2, Squarer.Square(number2));

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);

            var dv3 = dv1 + dv2;

            System.Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            /*static void Harry_Shout(object sender, EventArgs e)
            {
                Person p = (Person)sender;
                System.Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
                System.Console.WriteLine($"{p.GetType()}, {sender.GetType()}");
            }*/

            Employee john = new()
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28),
                EmployeeCode = "JJ001",
                HireDate = new DateTime(2024, 11, 23),
        };
            john.WriteToConsole();
            System.Console.WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");
            System.Console.WriteLine(john.ToString());
        }       
    }
}
