using System;

namespace Patterns.Bridge
{
    public class Remote
    {
        private readonly IDevice _device;

        public Remote(IDevice device) => _device = device;

        public void TurnOn() => _device.TurnOn();

        public void TurnOff() => _device.TurnOff();
    }
}