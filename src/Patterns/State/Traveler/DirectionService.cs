using System;

namespace Patterns.State.Traveler
{

    public class DirectionService
    {
        public ITravelMode TravelMode { get; set; }
        public int GetEta() => TravelMode.GetEta();
        public int GetDirection() => TravelMode.GetDirection();
    }
}