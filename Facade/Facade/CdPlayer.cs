using System;

namespace Facade
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("CD плеер включён.");
        }

        public void Off()
        {
            Console.WriteLine("CD плеер выключен.");
        }

        public void Eject()
        {
            Console.WriteLine("Диск извлечён.");
        }

        public void Pause()
        {
            Console.WriteLine("PAUSE");
        }

        public void Play(string name)
        {
            Console.WriteLine($"NOW PLAYING: {name}");
        }

        public void Stop()
        {
            Console.WriteLine("STOP");
        }
    }
}