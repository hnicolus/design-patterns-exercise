using System;

namespace Patterns.Prototype
{
    public class Text : IComponent
    {
        public Text(string content) => Content = content;
        public string Content { get; set; }

        public IComponent Clone()
        {
            var newText  = new Text(Content);
            return newText;
        }
    }
}