namespace Patterns.Observer
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}