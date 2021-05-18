using System;

namespace Patterns.State.Traveler
{

    public class DirectionService
    {
        public ITravelMode TravelMode { get; set; }
        public int getEta() => TravelMode.GetEta();
        public int getDirection() => TravelMode.GetDirection();
    }
}