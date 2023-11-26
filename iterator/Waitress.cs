namespace Iterator
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IteratorInterface pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IteratorInterface dinerIterator = _dinerMenu.CreateIterator();
            System.Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            System.Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IteratorInterface iterator)
        {
            while (iterator.HasNext())
            {
                MenuItems menuItems = (MenuItems)iterator.Next();
                System.Console.Write(menuItems.GetName() + ", ");
                System.Console.Write(menuItems.GetPrice() + " -- ");
                System.Console.WriteLine(menuItems.GetDescription());
            }
        }
    }
}