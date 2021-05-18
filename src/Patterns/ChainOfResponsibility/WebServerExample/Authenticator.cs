namespace Patterns.ChainOfResponsibility.WebServerExample
{
    public class Authenticator :Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }
        protected override bool Execute(HttpRequest request)
        {

            System.Console.WriteLine("Aunthetication ");
            bool isValid = (request.Username == "Admin" && request.Password == "123qwE*");
            return !isValid;
        }
    }

}