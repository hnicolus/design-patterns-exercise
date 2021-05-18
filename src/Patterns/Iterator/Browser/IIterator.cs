using System;

namespace Patterns.Iterator.Browser
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}