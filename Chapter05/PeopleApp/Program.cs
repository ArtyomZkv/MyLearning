﻿using Packt.Shared;
using System;

internal class Program
{
    static void Main()
    {
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
    }
}