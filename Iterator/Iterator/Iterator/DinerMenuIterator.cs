﻿using System;

namespace Iterator.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;
        private int position = 0;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}