using System;

namespace Patterns.Memento
{
    /// <summary>
    /// Memento
    /// This class Represents the Editor State
    /// </summary>
    public class EditorState
    {
        private readonly string _content;
        public string Content { get =>_content;  }
        public EditorState(string content)
        {
            _content = content;
        }
    }
}