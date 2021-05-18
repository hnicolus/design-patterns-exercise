using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{


    public class DataReader
    {
        private readonly Handler handler;

        public DataReader(Handler handler)
        {
            this.handler = handler;
        }
        public void Read(String fileName)
        {
            handler.Handle(fileName);
        }
    }
}