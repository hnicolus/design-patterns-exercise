using System.Threading;
using static System.Console;

namespace Patterns.Adapter.Gmail
{
    public class GmailClient
    {
        public static void Connect()
        {
            WriteLine("Connecting to Gmail");
            Thread.Sleep(2000);
        }

        public static void GetEmails()
        {
            WriteLine("Downloading emails from Gmail");
            Thread.Sleep(3000);

        }

        public static void Disconnect()
        {
            WriteLine("Disconnecting from Gmail");
            Thread.Sleep(2000);

        }
    }
}