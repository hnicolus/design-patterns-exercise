using System;
using static System.Console;
namespace Patterns.State.Traveler
{
    public class BicycleMode : ITravelMode
    {
        public int GetDirection()
        {
            WriteLine("Calculating Directions (bicycling)");
            return 1;
        }

        public int GetEta()
        {
            WriteLine("Calculating ETA (bicycling)");
            return 1;
        }
    }
}