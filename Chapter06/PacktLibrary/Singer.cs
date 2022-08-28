using System;

namespace PacktLibrary.Shared
{
    public class Singer
    {
        public virtual void Sing()
        {
            System.Console.WriteLine("Singing...");
        }
    }
    public class LadyGaga : Singer
    {
        public override sealed void Sing()
        {
            System.Console.WriteLine("Singing with style...");
        }
    }
}