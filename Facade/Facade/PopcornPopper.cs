using System;

namespace Facade
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper включён.");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper выключен.");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn popper работает.");
        }
    }
}