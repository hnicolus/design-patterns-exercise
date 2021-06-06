using System;

namespace Patterns.Bridge
{
    public static class DeviceRemoteProgram
    {
        public static void Run()
        {
            var sonyRemote = new Remote(new SonyDevice());
            sonyRemote.TurnOn();
            sonyRemote.TurnOff();

            var acerRemote = new Remote(new AcerDevice());
            acerRemote.TurnOn();
            acerRemote.TurnOff();

        }
    }
}