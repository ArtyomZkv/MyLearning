using System;

namespace PacktLibrary.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            System.Console.WriteLine("DVD player is paused.");
        }
        public void Play()
        {
            System.Console.WriteLine("DVD player is playing.");
        }
    }
}