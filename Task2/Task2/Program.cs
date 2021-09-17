using System;
using Task2.Publisher;
using Task2.Subscribers;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            CurrentDisplay display1 = new CurrentDisplay();
            StatisticsDisplay display2 = new StatisticsDisplay();
            EventWeatherData weatherData = new EventWeatherData();
            weatherData.AddSubscriber(display1);
            weatherData.AddSubscriber(display2);
            weatherData.NotifySubscribers();
        }
    }
}
