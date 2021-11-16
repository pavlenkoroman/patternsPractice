using System;
using Iterator.Iterator;

namespace Iterator
{
    public class DinerMenu : IMenu
    {
        private static int maxItems = 6;
        private static int numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[maxItems];
            AddItem(
                "Vegeterian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat. ",
                true,
                2.99
                );
            AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat.",
                false,
                2.99
                );
            AddItem(
                "Soup of the day",
                "Soup of the day, with the side of potato salad. ",
                false,
                3.29
                );
            AddItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false,
                3.05
                );
        }
        public void AddItem(string name, string desc, bool veg, double price)
        {
            var item = new MenuItem(name, desc, veg, price);
            if (numberOfItems >= maxItems)
            {
                Console.WriteLine("Menu is full. Can't add item.");
            }
            else
            {
                menuItems[numberOfItems] = item;
                numberOfItems++;
            }
        }
        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}