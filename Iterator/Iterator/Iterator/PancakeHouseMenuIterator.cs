using System.Collections.Generic;

namespace Iterator.Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> menuItems;
        private int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> list)
        {
            this.menuItems = list;
        }
        public bool HasNext()
        {
            if (position >= menuItems.Count || menuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            var menuItem = menuItems[position];
            position++;
            return menuItem;
        }
    }
}