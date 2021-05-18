using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{
    public class ExcelHandler : Handler
    {
        public ExcelHandler(Handler next) : base(next)
        {
        }

        protected override bool Execute(string fileName)
        {
            if (fileName.EndsWith(".xls"))
            {
                Console.WriteLine("Reading data from an Excel spreadsheet.");
                return true;
            }
            return false;
        }
    }
}