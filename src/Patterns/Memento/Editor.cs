using System;
using System.Collections.Generic;

namespace Patterns.Memento
{
    public class Editor
    {
        private string content;
        public string Content
        {
            get => content;
            set
            {
                content = value;

            }
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void RestoreState(EditorState state)
        {
            this.Content = state.Content;
        }
    }
}