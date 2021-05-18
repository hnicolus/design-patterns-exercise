using System;
using Patterns.Visitor;

namespace Patterns.Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }
}