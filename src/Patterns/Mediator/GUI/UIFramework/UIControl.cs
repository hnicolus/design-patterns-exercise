using System;
using System.Collections.Generic;

namespace Patterns.Mediator.GUI.UIFramework

{

    public abstract class UIControl : IObservable
    {
        protected List<IHandler> handlers = new();
        public void AddHandler(IHandler handler)
        {
            handlers.Add(handler);
        }

        public virtual void NotifyHandlers()
        {
            handlers.ForEach(handler =>
            {
                handler.Invoke();
            });
        }

        public virtual void RemoveHandler(IHandler handler)
        {
            handlers.Remove(handler);
        }
    }
}