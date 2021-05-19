using System.Threading;
using static System.Console;

namespace Patterns.Adapter.ICloud
{
    public class ICloudClient
    {
        public void Init()
        {
            WriteLine("Initialising ICloud Client");
            Thread.Sleep(2000);
        }
        public void GetEmails() => WriteLine("Getting Emails from Cloud");
    }
}