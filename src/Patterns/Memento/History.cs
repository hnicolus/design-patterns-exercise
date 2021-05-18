using System;
using System.Collections.Generic;

namespace Patterns.Memento
{
    public class History
    {
        List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }
        public EditorState Pop()
        {
            var indexOfLastState = states.Count - 1;
            var lastItem = states[indexOfLastState];

            states.Remove(lastItem);
            return lastItem;

        }
    }
}