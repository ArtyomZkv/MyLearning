using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4]
            {
                "Kate",
                "Jack",
                "Rebecca",
                "Tom"
            };
            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine(names[i]);
            }
        }
    }
}
