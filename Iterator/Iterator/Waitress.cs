using System;
using Iterator.Iterator;

namespace Iterator
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this._pancakeHouseMenu = pancakeHouseMenu;
            this._dinerMenu = dinerMenu;
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name} - {menuItem.Price}");
                Console.WriteLine($"{menuItem.Description}");
            }
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("------ PANCAKE MENU ------");
            PrintMenu(pancakeIterator);

            Console.WriteLine("\n------ DINER MENU ------");
            PrintMenu(dinerIterator);
        }
    }
}