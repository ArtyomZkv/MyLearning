using System;
using System.Xml.Linq;

namespace AssembliesAndNamespaces
{
    class Propgram
    {
        static void Main()
        {
            var doc = new XDocument();

            string s1 = "Hello";
            string s2 = "World";

            Console.WriteLine($"{s1} {s2}");
        }
    }
}
