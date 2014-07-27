using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver
    {
        private double temperature;
        private double humidity;
        private double pressure;

        WeatherData WeatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("The Current Conditions are:");
            Console.WriteLine("\tTemperature: " + this.temperature + " F");
            Console.WriteLine("\tHumidity: " + this.humidity + "%");
            Console.WriteLine("\tPressure: " + this.pressure);
        }

        public void Update()
        {
            this.temperature = this.WeatherData.Temperature;
            this.humidity = this.WeatherData.Humidity;
            this.pressure = this.WeatherData.Pressure;

            this.Display();
        }
    }
}
