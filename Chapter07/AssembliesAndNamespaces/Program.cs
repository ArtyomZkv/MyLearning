using System;
using SharedLibrary;

using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;

namespace AssembliesAndNamespaces
{
    class Propgram
    {
        static void Main()
        {
            System.Console.WriteLine("Enter a color value in hex :");
            string hex = Console.ReadLine();
            System.Console.WriteLine($"Is {hex} a valid color value {hex.IsValidHex()}");

            System.Console.WriteLine("Enter a XML element: ");
            string xmlTag = Console.ReadLine();
            System.Console.WriteLine($"Is {xmlTag} a valid XML element? {xmlTag.IsValidXmlTag()}");

            System.Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            System.Console.WriteLine($"Is {password} a valid password? {password.IsValidPassword()}");

            var x = new Axis("x", 0, 10, 1);
            var y = new Axis("y", 0, 4, 1);

            var matrix = new Matrix<long>(new [] { x, y });
            
            for (int i = 0; i < matrix.Axes[0].Points.Length; i++)
            {
                matrix.Axes[0].Points[i].Label = "x" + i.ToString();
            }

            for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
            {
                matrix.Axes[1].Points[i].Label = "y" + i.ToString();
            }

            foreach(long[] c in matrix)
            {
                matrix[c] = c[0] + c[1];
            }

            foreach(long[] c in matrix)
            {
                System.Console.WriteLine($"{matrix.Axes[0].Points[c[0]].Label},{matrix.Axes[1].Points[c[1]].Label} ({c[0]}, {c[1]}) = {matrix[c]}");
            }
        }
    }
}
