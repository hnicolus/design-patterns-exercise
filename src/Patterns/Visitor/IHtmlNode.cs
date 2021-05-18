using System;
using Patterns.Visitor;

namespace Patterns.Visitor
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}