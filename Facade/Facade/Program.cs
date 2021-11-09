using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Amplifier amplifier = new Amplifier(tuner, dvd, cd);
            Projector projector = new Projector(dvd);
            TheaterLights theaterLights = new TheaterLights();
            Screen screen = new Screen();
            PopcornPopper popcornPopper = new PopcornPopper();
            HomeTheaterFacade facade = new HomeTheaterFacade(amplifier, tuner, cd, dvd, projector, theaterLights, screen, popcornPopper);

            facade.WatchMovie("терминатор");
        }
    }
}
