using System;

namespace Facade
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Тюнер включён.");
        }

        public void Off()
        {
            Console.WriteLine("Тюнер выключен.");
        }

        public void SetAm()
        {
            Console.WriteLine("AM is set.");
        }

        public void SetFm()
        {
            Console.WriteLine("Fm is set.");
        }

        public void SetFrequency(int frequency)
        {
            Console.WriteLine($"Выставлена частота {frequency}.");
        }
    }
}