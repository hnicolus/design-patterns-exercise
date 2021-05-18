using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{
    public class FallBackHandler : Handler
    {
        public FallBackHandler(Handler next) : base(next)
        {
        }

        protected override bool Execute(string fileName)
        {
            System.Console.WriteLine("File Format Not Supported.");
            throw new NotSupportedException("File format not supported.");
        }
    }
}