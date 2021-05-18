using System.Collections.Generic;
using System;

namespace Patterns.Mediator.GUI.UIFramework

{

    public abstract class UIControl : IObservable
    {
        protected List<IHandler> handlers = new List<IHandler>();
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