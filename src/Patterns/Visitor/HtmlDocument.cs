using System;
using System.Collections.Generic;

namespace Patterns.Visitor
{
    public class HtmlDocument
    {
        List<IHtmlNode> nodes = new List<IHtmlNode>();
        public void AddNode(IHtmlNode node) => nodes.Add(node);
        public void HighLight()
        {
            var highLightOperation = new HighLightOperation();
            nodes.ForEach(node => node.Execute(highLightOperation));
        }
    }
}