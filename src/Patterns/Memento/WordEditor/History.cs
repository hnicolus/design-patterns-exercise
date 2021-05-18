using System.Linq;
using System;
using System.Collections.Generic;

namespace Patterns.Memento.WordEditor
{
    public class History
    {
        private readonly Stack<DocumentState> _states = new Stack<DocumentState>();

        public void Push(DocumentState state) => _states.Push(state);
        public DocumentState Pop() => _states.Pop();
    }
}