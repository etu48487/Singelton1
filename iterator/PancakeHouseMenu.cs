using System;

namespace Iterator
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItemList;

        public PancakeHouseMenu()
        {
            MenuItemList = new List<MenuItem>();

            AddItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItemList.Add(menuItem);
        }

        public IteratorInterface CreateIterator()
        {
            return new PancakeIterator(MenuItemList);
        }
    }
}