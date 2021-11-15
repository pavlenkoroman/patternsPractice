using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress(new PancakeHouseMenu(), new DinerMenu());

            waitress.PrintMenu();
        }
    }
}
