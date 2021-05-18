using System;

namespace Patterns.Observer.FirstWay
{
    public class DuePointDisplay : IObserver
    {
        public void Update(IObservable observable)
        {
            var WeatherDataSource = observable as WeatherDataSource;
            System.Console.WriteLine("The Updated Due Point is "+ WeatherDataSource.DuePoint );
        }
    }
}