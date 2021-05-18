using System.Runtime.InteropServices.ComTypes;
using System;

namespace Patterns.ChainOfResponsibility.WebServerExample
{
    public class WebServer
    {
        private readonly Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }
        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
        }
    }
}