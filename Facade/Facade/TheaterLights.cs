using System;

namespace Facade
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Свет в зале включён.");
        }

        public void Off()
        {
            Console.WriteLine("Свет в зале выключен.");
        }

        public void Dim(int a)
        {
            Console.WriteLine($"Мощность света: {a}%.");
        }
    }
}