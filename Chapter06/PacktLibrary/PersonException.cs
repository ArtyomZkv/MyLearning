using System;

namespace PacktLibrary.Shared
{
    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) : base() { }
        public PersonException(string message, Exception innerException) : base(message, innerException) { }
    }
}