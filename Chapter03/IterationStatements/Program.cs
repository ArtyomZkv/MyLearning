﻿using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                System.Console.WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
