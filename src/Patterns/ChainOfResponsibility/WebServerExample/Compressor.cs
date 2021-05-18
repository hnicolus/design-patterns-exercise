namespace Patterns.ChainOfResponsibility.WebServerExample
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public void Compress()
        {
        }

        protected override bool Execute(HttpRequest request)
        {
            System.Console.WriteLine("Compressing");
            return false;
        }
    }
}