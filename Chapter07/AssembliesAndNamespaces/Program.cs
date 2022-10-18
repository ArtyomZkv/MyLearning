using System;
using SharedLibrary;

namespace AssembliesAndNamespaces
{
    class Propgram
    {
        static void Main()
        {
            System.Console.WriteLine("Enter a color value in hex :");
            string hex = Console.ReadLine();
            System.Console.WriteLine($"Is {hex} a valid color value {hex.IsValidHex}");

            System.Console.WriteLine("Enter a XML element: ");
            string xmlTag = Console.ReadLine();
            System.Console.WriteLine($"Is {xmlTag} a valid XML element? {xmlTag.IsValidXmlTag()}");

            System.Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            System.Console.WriteLine($"Is {password} a valid password? {password.IsValidPassword()}");
        }
    }
}
