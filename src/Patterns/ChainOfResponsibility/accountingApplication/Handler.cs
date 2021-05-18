using System;

namespace Patterns.ChainOfResponsibility.accountingApplication
{
    public abstract class Handler
    {
        private readonly Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(string fileName)
        {
            if (Execute(fileName)) return;

            if(next != null)
                next.Handle(fileName);
        }

        protected abstract bool Execute(string fileName);
    }
}