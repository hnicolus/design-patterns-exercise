using System;
using Patterns.Visitor;
using static System.Console;
namespace Patterns.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(HeadingNode node) =>WriteLine("Highlight-Heading");
        public void Apply(AnchorNode node)=> WriteLine("Highlight-Anchor");
    }
}