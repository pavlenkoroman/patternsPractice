using System;
using System.Threading.Channels;

namespace Facade
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD плеер включён.");
        }

        public void Off()
        {
            Console.WriteLine("DVD плеер выключен.");
        }

        public void Eject()
        {
            Console.WriteLine("DVD диск извлечён.");
        }

        public void Pause()
        {
            Console.WriteLine("Поставлена пауза.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"NOW PLAYING: {movie}");
        }
        public void Stop()
        {
            Console.WriteLine("STOP.");
        }
    }
}