namespace Patterns.Mediator.GUI.UIFramework
{
    public delegate void IHandler();

    public interface IObservable
    {
        void AddHandler(IHandler handler);
        void RemoveHandler(IHandler handler);
        void NotifyHandlers();
    }
}