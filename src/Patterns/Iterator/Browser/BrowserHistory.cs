using System.Reflection.Emit;
using System;
using System.Collections.Generic;

namespace Patterns.Iterator.Browser
{
    public class BrowserHistory
    {
        private List<string> urls = new List<string>();
        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var index = urls.Count - 1;
            var item = urls[index];
            urls.Remove(item);
            return item;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowserHistory browserHistory;
            private int index = 0;

            public ListIterator(BrowserHistory browserHistory)
            {
                this.browserHistory = browserHistory;
            }
            public string Current()
            {
                return browserHistory.urls[index];
            }

            public bool HasNext()
            {
                return (index < browserHistory.urls.Count );
            }

            public void Next()
            {
                index++;
            }
        }
    }
}