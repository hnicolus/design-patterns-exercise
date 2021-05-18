using System.Diagnostics;
using System;

namespace Patterns.ChainOfResponsibility.WebServerExample
{
    public abstract class Handler
    {
        private readonly Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (Execute(request))
                return;

            if (next != null)
                next.Handle(request);
        }

        protected abstract bool Execute(HttpRequest request);
    }
}