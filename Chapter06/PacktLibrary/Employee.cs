using System;

namespace PacktLibrary.Shared
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            System.Console.WriteLine("{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            Name,
            DateOfBirth,
            HireDate);
        }
    }
}