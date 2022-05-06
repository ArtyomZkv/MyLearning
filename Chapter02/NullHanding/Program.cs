#nullable enable
using System;

namespace NullHanding
{
    class Program
    {
        static void Main()
        {
            string thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            //System.Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var adress = new Adress()
            {
                Building = null,
                Street = null,
                City = null,
                Region = null
            };

        }
    }
    class Adress
    {
        public string Building;
        public string Street = null;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
}
