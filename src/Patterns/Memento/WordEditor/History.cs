using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Memento.WordEditor
{
    public class History
    {
        private readonly Stack<DocumentState> _states = new();

        public void Push(DocumentState state) => _states.Push(state);
        public DocumentState Pop() => _states.Pop();
    }
}