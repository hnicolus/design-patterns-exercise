using System;

namespace Patterns.Observer.FirstWay
{
    public class TemperatureDisplay : IObserver
    {
        public void Update(IObservable observable)
        {
            var WeatherDataSource = observable as WeatherDataSource;
            System.Console.WriteLine("The Updated Temperature is " + WeatherDataSource.Temperature);
        }
    }
}