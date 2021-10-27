using System;

namespace Adapter
{
    public class Turkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying slow");
        }
    }
}