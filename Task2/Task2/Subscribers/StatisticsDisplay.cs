using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2.Subscribers
{
    public class StatisticsDisplay : ISubscriber
    {
        private static List<double> tempList = new List<double>() { 22, 38, 25 };
        private static List<double> humidityList = new List<double>() { 30, 44, 55, 29 };
        private static List<double> pressureList = new List<double>() { 632, 711, 703, 801 };
        public void GetNotify(double temp, double pressure, double humidity)
        {
            tempList.Add(temp);
            humidityList.Add(humidity);
            pressureList.Add(pressure);

            Console.WriteLine("-----СРЕДНИЕ ЗНАЧЕНИЯ ЗА СЕГОДНЯ::-----");
            Console.WriteLine($"Средняя температура: {FindAverage(tempList)} град. Цельсия");
            Console.WriteLine($"Среднее давление: {FindAverage(pressureList)} мм.рт.ст.");
            Console.WriteLine($"Средняя влажность воздуха: {FindAverage(humidityList)} %");
        }

        private static double FindAverage(List<double> data) 
        {
            double avg;
            avg = data.Average();
            return avg;
        }
    }
}
