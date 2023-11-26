namespace Iterator
{
    public class MenuItems
    {
        public string Name;
        public string Description;
        public bool Vegetarian;
        public double Price;

        public MenuItems(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public Boolean GetVegetarian()
        {
            return Vegetarian;
        }
        public double GetPrice()
        {
            return Price;
        }
    }
}