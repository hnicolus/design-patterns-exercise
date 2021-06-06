using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Patterns.Iterator.Browser
{
    public class BrowserHistory
    {
        private readonly List<string> _urls = new();
        public void Push(string url)
        {
            _urls.Add(url);
        }

        public string Pop()
        {
            var index = _urls.Count - 1;
            var item = _urls[index];
            _urls.Remove(item);
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
                return browserHistory._urls[index];
            }

            public bool HasNext()
            {
                return (index < browserHistory._urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}