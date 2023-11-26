using System;

namespace Iterator
{
    public class DinerMenu
    {
        private int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItems[] menuItemList;

        public DinerMenu()
        {
            menuItemList = new MenuItems[MAX_ITEMS];
            addItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat",true, 2.99);
            addItem("BLT","Bacon with lettuce & tomato on whole wheat", false, 2.99);
    	    addItem("Soup of the day","Soup of the day, with a side of potato salad", false, 3.29);
    	    addItem("Hotdog","A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
    	    addItem("Steamed Veggies and Brown Rice","Steamed vegetables over brown rice", true, 3.99);
    	    addItem("Pasta","Spaghetti with Marinara Sauce, and a slice of sourdough bread",true, 3.89);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItems menuItem = new MenuItems(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItemList[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IteratorInterface createIterator()
        {
            return new DinerMenuIterator(menuItemList);
        }
    }
}