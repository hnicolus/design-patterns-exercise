using System;

namespace Patterns.Iterator.Browser
{
    public static class BrowserProgram
    {
        public static void Run()
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("https://www.nicksoftware.co.za");
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.github.com/hnicolus");

            var iterator = browserHistory.CreateIterator();

            while (iterator.HasNext())
            {
                var current = iterator.Current();
                System.Console.WriteLine(current);
                iterator.Next();
            }
        }
    }
}