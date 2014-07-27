using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        public double Temperature;
        public double Humidity;
        public double Pressure;

        private IList<IObserver> observers = new List<IObserver>();

        public WeatherData()
        {
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }
        }

        public void UpdateMeasurements(float temp, float humidity, float pressure)
        {
            this.Temperature = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.NotifyObservers();
        }
    }
}
