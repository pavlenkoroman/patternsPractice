using System.Collections.Generic;
using Iterator.Iterator;

namespace Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem(
                    "K&B's Pancake Breakfast",
                    "Pancakes with the scramled eggs, and toast",
                    true,
                    2.99);
            AddItem(
                    "Regullar Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99);
            AddItem(
                    "Blueberry pancakes",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49);
            AddItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        public void AddItem(string name, string desc, bool veg, double price)
        {
            var item = new MenuItem(name, desc, veg, price);
            menuItems.Add(item);
        }
        public IIterator<MenuItem> CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}