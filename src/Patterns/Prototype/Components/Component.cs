using System;

namespace Patterns.Prototype
{
    public interface IComponent
    {
        public IComponent Clone();
    }
}