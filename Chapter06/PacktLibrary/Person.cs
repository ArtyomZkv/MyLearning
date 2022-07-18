namespace PacktLibrary.Shared
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public string DateOfBirth;
        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            System.Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }
        public static Person Procreate (Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        public static Person operator * (Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            static int localFactorial(int localNumber)
            {
                if (localNumber < 1 ) return 1;

                return localNumber * localFactorial(localNumber - 1);
            }
        }
        public event EventHandler Shout;

        public int AngerLevel;

        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return result;
            }
        }
    }
}

