using System;

namespace Iterator
{
    public class DinerMenuIterator : IteratorInterface
    {
        private MenuItems[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItems[] items)
        {
            _items = items;
        }

        public object Next()
        {
            MenuItems menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}