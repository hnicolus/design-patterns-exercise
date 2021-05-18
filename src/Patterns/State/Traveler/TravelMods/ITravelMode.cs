using System;

namespace Patterns.State.Traveler
{
    public interface ITravelMode
    {
        int GetEta();
        int GetDirection();
    }
}