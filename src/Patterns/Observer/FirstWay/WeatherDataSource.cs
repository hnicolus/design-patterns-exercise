using System.Collections.Generic;

namespace Patterns.Observer
{

    public class WeatherDataSource : IObservable
    {
        private readonly List<IObserver> _observers = new();
        private float duePoint;
        private float temperature;

        public float Temperature
        {
            get => temperature; set
            {
                temperature = value;
                NotifyObservers();
            }
        }
        public float DuePoint
        {
            get => duePoint;
            set
            {
                duePoint = value;
                NotifyObservers();
            }
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            _observers.ForEach(ob =>
            {
                ob.Update(this);
            });
        }

    }
}