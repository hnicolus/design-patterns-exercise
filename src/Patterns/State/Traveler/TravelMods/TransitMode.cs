using System;

namespace Patterns.State.Traveler
{
    public class TransitMode : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}