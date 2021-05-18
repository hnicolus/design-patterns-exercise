using System.Security.Cryptography.X509Certificates;
using System;

namespace Patterns.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation) => operation.Apply(this);
    }
}