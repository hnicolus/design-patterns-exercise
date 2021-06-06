using System;

namespace Patterns.Bridge
{
    internal class AcerDevice : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine($"{nameof(AcerDevice)} Turning off...");
        }

        public void TurnOn()
        {
            Console.WriteLine($"{nameof(AcerDevice)} Turning on...");
        }
    }
}