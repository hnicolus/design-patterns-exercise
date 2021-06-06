using System;
using System.Collections.Generic;

namespace Patterns.Memento
{
    public class History
    {
        readonly List<EditorState> _states = new();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }
        public EditorState Pop()
        {
            var indexOfLastState = _states.Count - 1;
            var lastItem = _states[indexOfLastState];

            _states.Remove(lastItem);
            return lastItem;

        }
    }
}