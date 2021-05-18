namespace Patterns.ChainOfResponsibility.WebServerExample
{
    public class Logger:Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        protected override bool Execute(HttpRequest request)
        {
            System.Console.WriteLine("Logging");
            return false;
        }

    }
}