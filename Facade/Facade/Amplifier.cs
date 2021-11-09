using System;

namespace Facade
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }

        public Amplifier(Tuner tuner, DvdPlayer dvd, CdPlayer cd)
        {
            this.Tuner = tuner;
            this.DvdPlayer = dvd;
            this.CdPlayer = cd;
        }
        public void On()
        {
            Console.WriteLine("Усилитель включён.");
        }
        public void Off()
        {
            Console.WriteLine("Усилитель выключен.");
        }
        public void SetCD()
        {
            Console.WriteLine("CD диск вставлен.");
        }
        public void SetDVD()
        {
            Console.WriteLine("DVD диск вставлен.");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Звук включён в режиме 'стерео'.");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Объёмный звук включён.");
        }
        public void SetTuner()
        {
            Console.WriteLine("Тюнер включён.");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"Громкость {value}.");
        }

    }
}