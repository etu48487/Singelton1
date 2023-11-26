using System.Collections.Generic;

namespace Iterator
{
    public class PancakeIterator : IteratorInterface
    {
        List<object> items;
        int position = 0;

        public PancakeIterator(List<object> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count)
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
            MenuItems menuItem = (MenuItems)items[position];
            position = position + 1;
            return menuItem;
        }
    }
}