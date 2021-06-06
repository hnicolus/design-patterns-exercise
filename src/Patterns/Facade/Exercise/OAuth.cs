namespace Patterns.Facade.Exercise
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {

            System.Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string GetAccessToken(string requestToken)
        {
            System.Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}