using System;

namespace Patterns.Bridge
{
    public class SonyDevice : IDevice
    {
        public void TurnOff()
        {
            System.Console.WriteLine($"{nameof(SonyDevice)} turning off..");
        }

        public void TurnOn()
        {
            System.Console.WriteLine($"{nameof(SonyDevice)} turning on..");

        }
    }
}