using System;
using System.Collections.Generic;

namespace Patterns.Visitor
{
    public class HtmlDocument
    {
        readonly List<IHtmlNode> _nodes = new();
        public void AddNode(IHtmlNode node) => _nodes.Add(node);
        public void HighLight()
        {
            var highLightOperation = new HighLightOperation();
            _nodes.ForEach(node => node.Execute(highLightOperation));
        }
    }
}