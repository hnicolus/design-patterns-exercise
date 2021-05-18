using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{
    public class SpreadSheetHandler : Handler
    {
        public SpreadSheetHandler(Handler next) : base(next)
        {
        }

        protected override bool Execute(string fileName)
        {
            if (fileName.EndsWith(".numbers"))
            {
                Console.WriteLine("Reading data from a Numbers spreadsheet.");
                return true;
            }
            else
                return false;
        }
    }
}