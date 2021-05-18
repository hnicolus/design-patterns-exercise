using System;

namespace Patterns.State.Traveler
{
    public class DrivingMode : ITravelMode
    {
        public int GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int GetEta()
        {
            Console.WriteLine("Calculating ETA (driving");
            return 1;
        }
    }
}