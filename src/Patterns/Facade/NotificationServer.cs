using System.Net.Security;

namespace Patterns.Facade
{
    public class NotificationServer
    {
        //Connect():Connection;
        ///Authenticate(appID,key) :AuthToken
        ///Send(authToken,message,target)
        ///connection.Disconnect()
        ///

        public Connection Connect(string iPAddress)
        {
            return new Connection(iPAddress);
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken(appId, key);
        }

        public void Send(AuthToken token, string message, string target)
        {
            System.Console.WriteLine("Sending message...");
        }

    }
}