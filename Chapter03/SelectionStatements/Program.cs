using System;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*if (args.Length == 0)
            {
                System.Console.WriteLine("There are no arguments");
            }
            else
            {
                System.Console.WriteLine("There is at least one arguments.");
            }
            object o = 3;
            int j = 4;

            if(o is int i)
            {
                System.Console.WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                System.Console.WriteLine("o is not an int so in cannot multiply");
            }

            A_label:
            var number = new Random().Next(1, 7);
            System.Console.WriteLine($"My random number is {number}");

            switch(number)
            {
                case 1:
                    System.Console.WriteLine("One");
                    break;
                case 2:
                    System.Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    System.Console.WriteLine("Three or four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    System.Console.WriteLine("Default");
                    break;
*/
                    string path = @"G:\Projects\2022\LearningRepos\Chapter03";

                    Console.Write("Press R for readonly or W for write: ");

                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.WriteLine();

                    Stream s = null;

                    if (key.Key == ConsoleKey.R)
                    {
                        s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
                    }
                    else
                    {
                        s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
                    }

                    string message = string.Empty;

                    switch(s)
                    {
                        case FileStream writeableFile when s.CanWrite:
                            message = "The stream is a file that I can write to.";
                            break;
                        case FileStream readOnlyFile:
                            message = "The stream is a read-only file.";
                            break;
                        case MemoryStream ms:
                            message = "The stream is a memory address.";
                            break;
                        default:
                            message = "The stream is some other type.";
                            break;
                        case null:
                            message = "The stream is null.";
                            break;
                    }
                    System.Console.WriteLine(message);

            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "The stream is a file that i can write to.",
                FileStream readOnlyFile
                    => "The stream is a read-only file.",
                MemoryStream memoryStream
                    => "The stream is a memory adress.",
                null
                    => "The stream is null.",
                _
                    => "The stream is some other type."

            };
            System.Console.WriteLine(message);
        }
    }
}
