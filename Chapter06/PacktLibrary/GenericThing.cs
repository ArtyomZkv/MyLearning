using System;

namespace PacktLibrary.Shared
{
    public class GenericThing<T> where T: IComparable
    {
        public T Data;
        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "Data and input are the same.";
            }
            else 
            {
                return "Data and input are NOT the same.";
            }
        }
    }
}