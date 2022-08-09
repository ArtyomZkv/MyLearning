using System;

namespace PacktLibrary.Shared
{
    public class Thing
    {
        public object Data;
        public string Process(string input)
        {
            if (Data.ToString() == input)
            {
                return "Data and imput are the same.";
            }
            else
            {
                return "Data and imput are NOT the same.";
            }
        }
    }
}