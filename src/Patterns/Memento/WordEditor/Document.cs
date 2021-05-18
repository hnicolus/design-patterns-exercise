using System;

namespace Patterns.Memento.WordEditor
{
    public class Document
    {
        private string content;
        private string fontName;
        private int fontSize;

        public string Content
        {
            get => content;
            set
            {
                content = value;
            }
        }
        public string FontName { get => fontName; set => fontName = value; }
        public int FontSize { get => fontSize; set => fontSize = value; }

        public DocumentState CreateState()
        {
            return new DocumentState
            {
                Content = this.Content,
                FontName = this.FontName,
                FontSize = this.FontSize
            };
        }

        public void RestoreState(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }
    }
}