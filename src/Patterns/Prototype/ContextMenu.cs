using System;

namespace Patterns.Prototype
{
    public static class ContextMenu
    {
        public static IComponent Duplicate(IComponent component)
        {
            return component.Clone();
        }
    }
}