using System;

namespace Patterns.Iterator.Products
{
    public interface IITerator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}