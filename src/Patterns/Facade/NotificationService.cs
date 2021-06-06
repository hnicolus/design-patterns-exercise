namespace Patterns.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("");
            var authToken = server.Authenticate("", "");
            server.Send(authToken, message, target);
            connection.Disconnect();
        }
    }
}