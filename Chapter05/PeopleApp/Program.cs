﻿using Packt.Shared;
using System;

internal class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int d = 10;
        int e = 20;

        var bob = new Person()
        {
            Name = "Bob Smith",
            DateOfBirth = new DateTime(1965, 12, 22)
        };
        var alice = new Person()
        {
            Name = "Alice Jonson",
            DateOfBirth = new DateTime(1998, 3, 7)
        };

        Console.WriteLine(
            format: "{0} was born on {1:dddd, dd MMMM yyyy}",
            arg0: bob.Name,
            arg1: bob.DateOfBirth);

        Console.WriteLine(
            format: "{0} was born in {1: dd MM yy}",
            arg0: alice.Name,
            arg1: alice.DateOfBirth
        );

        bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtEphesus;

        Console.WriteLine(format:
                    "{0}'s favorite" +
                    "wonder is {1}. It's " +
                    "integer is {2}.",
                bob.Name,
                bob.FavoriteAncientWonder,
                (int)bob.FavoriteAncientWonder);

        bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
         | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

        Console.WriteLine($"{bob.Name}'s bucket list in {bob.BucketList}");

        bob.Children.Add(new Person { Name = "Alfred", DateOfBirth = new DateTime(2001, 7, 14) });
        bob.Children.Add(new Person { Name = "Zoe", DateOfBirth = new DateTime(2001, 3, 5) });
        for (int i = 0; i < bob.Children.Count; i++)
        {
            System.Console.WriteLine($"Bob's child named " +
                                            $"{bob.Children[i].Name}, " +
                                            $"and borned in {bob.Children[0].DateOfBirth.Year}");
        }

        BankAccount.InterestRate = 0.012M;

        var jonesAccount = new BankAccount()
        {
            AccountName = "Mrs. Jones",
            Balance = 2400
        };

        var gerrierAccount = new BankAccount()
        {
            AccountName = "Ms. Gerrier",
            Balance = 98
        };

        System.Console.WriteLine(format: "{0} earned {1:C} interest.",
                                jonesAccount.AccountName,
                                jonesAccount.Balance);
        System.Console.WriteLine(format: "{0} earned {1:C} interest.",
                                gerrierAccount.AccountName,
                                gerrierAccount.Balance);

        System.Console.WriteLine($"{bob.Name} is a {Person.Species}");

        System.Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

        var blankPerson = new Person();
        System.Console.WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                                blankPerson.Name,
                                blankPerson.HomePlanet,
                                blankPerson.Instantiated);

        var gunny = new Person("Gunny", "Mars");
        System.Console.WriteLine(format: "{0} of {1} was created at {2: hh:mm:ss} on a {2:dddd}.",
                                gunny.Name,
                                gunny.HomePlanet,
                                gunny.Instantiated);

        bob.WriteToConsole();
        System.Console.WriteLine(bob.GetOrigin());

        (string, int) fruit = bob.GetFruit();

        System.Console.WriteLine($"{fruit.Item1}, {fruit.Item2} there are");

        var fruitNamed = bob.GetNamedFruit();
        System.Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

        var thing1 = ("Neville", 4);
        System.Console.WriteLine($"{thing1.Item1} has {thing1.Item2} children");

        var thing2 = (bob.Name, bob.Children.Count);
        System.Console.WriteLine($"{thing2.Name} has {thing2.Name} children");

        (string fruitName, int fruitNumber) = bob.GetFruit();
        System.Console.WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

        System.Console.WriteLine(bob.SayHello());
        System.Console.WriteLine(bob.SayHelloTo("Emily"));

        System.Console.WriteLine(bob.OptionalParameters());
        System.Console.WriteLine(bob.OptionalParameters("Jump!", 98.5));
        System.Console.WriteLine(bob.OptionalParameters(number: 52.7, command: "Stay"));
        System.Console.WriteLine(bob.OptionalParameters("Poke", active: false));

        System.Console.WriteLine($"Before: a = {a}, b = {b}, c = {c}");
        bob.PassingParameters(a, ref b, out c);
        System.Console.WriteLine($"After: a = {a}, b = {b}, c = {c}");

        System.Console.WriteLine($"Before: d = {d}, e = {e}");
        bob.PassingParameters(d, ref e, out int f);
        System.Console.WriteLine($"After: d = {d}, e = {e}, f = {f}");

        var sam = new Person
        {
            Name = "Sam",
            DateOfBirth = new DateTime(1972, 1, 27)
        };

        System.Console.WriteLine(sam.Origin);
        System.Console.WriteLine(sam.Greeting);
        System.Console.WriteLine(sam.Age);

        sam.FavoritePrimaryColor = "red";
        System.Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");

        sam.Children.Add(new Person { Name = "Charlie" });
        sam.Children.Add(new Person { Name = "Ella" });

        System.Console.WriteLine($"Sam's first child is {sam.Children[0]}");
        System.Console.WriteLine($"Sam's first child is {sam[0].Name}");

        object[] passengers = {
            new FirstClassPassenger { AirMiles = 1_419 },
            new FirstClassPassenger { AirMiles = 16_562 },
            new BuisnessClassPassenger(),
            new CoachClassPassenger { CarryOnKG = 25.7 },
            new CoachClassPassenger { CarryOnKG = 0 }
        };

        foreach (object passenger in passengers)
        {
            decimal flightCost = passenger switch
            {
                FirstClassPassenger p => p.AirMiles switch
                {
                    > 35000 => 1500M,
                    > 15000 => 1750M,
                    _ => 2000M
                },
                BuisnessClassPassenger => 1000M,
                CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                CoachClassPassenger => 650M,
                _ => 800M
            };
            System.Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");

            var jeff = new ImmutablePerson
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };

            //jeff.FirstName = "Geoff";
            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metallic",
                Wheels = 4
            };

            var repaintedCar = car with { Color = "Polymenral Grey Metallic" };
            System.Console.WriteLine("Original color was {0}, new color is {1}.", car.Color, repaintedCar.Color);
        }
    }
}