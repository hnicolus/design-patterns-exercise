using System.Threading;
using static System.Console;

namespace Patterns.Adapter.Gmail
{
    public class GmailClient
    {
        public void connect()
        {
            WriteLine("Connecting to Gmail");
            Thread.Sleep(2000);
        }

        public void getEmails()
        {
            WriteLine("Downloading emails from Gmail");
            Thread.Sleep(3000);

        }

        public void disconnect()
        {
            WriteLine("Disconnecting from Gmail");
            Thread.Sleep(2000);

        }
    }
}