using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{
    public class QuickBookHandler : Handler
    {
        public QuickBookHandler(Handler next) : base(next)
        {
        }

        protected override bool Execute(string fileName)
        {
            if(!fileName.EndsWith(".qbw"))
                return false;

            Console.WriteLine("Reading data from a QuickBooks file.");
            return true;
        }
    }
}