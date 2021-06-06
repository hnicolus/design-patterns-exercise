using System;

namespace Patterns.Facade
{
    public class Connection
    {
        private readonly string ipAddress;
        public Connection(string ipAddress)
        {
            this.ipAddress = ipAddress;

        }

        public void Disconnect()
        {
            System.Console.WriteLine($"Disconnecting {ipAddress}...");
        }
    }
}