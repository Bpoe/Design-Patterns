using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);

            weatherData.UpdateMeasurements(75, 70, 20);
            weatherData.UpdateMeasurements(72, 72, 21);
            weatherData.UpdateMeasurements(70, 74, 22);

            Console.Read();
        }
    }
}
