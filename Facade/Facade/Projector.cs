using System;
using System.Threading.Channels;

namespace Facade
{
    public class Projector
    {
        public DvdPlayer DvdPlayer { get; set; }

        public Projector(DvdPlayer dvd)
        {
            this.DvdPlayer = dvd;
        }

        public void On()
        {
            Console.WriteLine("Проектор включён.");
        }

        public void Off()
        {
            Console.WriteLine("Проектор выключен.");
        }

        public void TvMode()
        {
            Console.WriteLine("Проектор включён в режиме TV.");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Включён широкоэкранный режим.");
        }

    }
}