using System;

namespace Patterns.State.Traveler
{
    public class WalkingMode : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (Walking)");
            return 3;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (Walking)");
            return 3;
        }
    }
}