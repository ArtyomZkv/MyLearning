using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            try
            {
                    for (byte i = 0; i < max; i++)
                    {
                        System.Console.WriteLine(i);
                    }
            }
            catch
            {
                System.Console.WriteLine("Ошибка переполнения!");
            }

        }
    }
}
