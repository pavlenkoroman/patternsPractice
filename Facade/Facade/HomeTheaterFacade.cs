using System;

namespace Facade
{
    public class HomeTheaterFacade
    {
        public Amplifier Amplifier { get; set; }
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }
        public Projector Projector { get; set; }
        public TheaterLights TheaterLights { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper PopcornPopper { get; set; }

        public HomeTheaterFacade(
            Amplifier amplifier, Tuner tuner, CdPlayer cdPlayer,
            DvdPlayer dvdPlayer, Projector projector, TheaterLights theaterLights,
            Screen screen, PopcornPopper popcornPopper)
        {
            this.Amplifier = amplifier;
            this.Tuner = tuner;
            this.DvdPlayer = dvdPlayer;
            this.CdPlayer = cdPlayer;
            this.Projector = projector;
            this.TheaterLights = theaterLights;
            this.Screen = screen;
            this.PopcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(10);
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amplifier.On();
            Amplifier.SetDVD();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(50);
            DvdPlayer.On();
            DvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Screen.Up();
            Projector.Off();
            Amplifier.Off();
            DvdPlayer.Stop();
            DvdPlayer.Eject();
            DvdPlayer.Off();
        }

        public void ListenToCd(string name)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(10);
            Amplifier.On();
            Amplifier.SetCD();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(50);
            CdPlayer.On();
            CdPlayer.Play(name);
        }

        public void EndCd()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Amplifier.Off();
            CdPlayer.Stop();
            CdPlayer.Eject();
            CdPlayer.Off();
        }

        public void ListenRadio(int frequency)
        {
            PopcornPopper.On();
            PopcornPopper.Pop();
            TheaterLights.Dim(10);
            Amplifier.On();
            Amplifier.SetTuner();
            Amplifier.SetSurroundSound();
            Amplifier.SetVolume(50);
            Tuner.On();
            Tuner.SetFm();
            Tuner.SetFrequency(frequency);
        }

        public void EndRadio()
        {
            PopcornPopper.Off();
            TheaterLights.On();
            Amplifier.Off();
            Tuner.Off();
        }
    }
}