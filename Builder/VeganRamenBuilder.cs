namespace Builder
{
    using System.Collections.Generic;

    public class VeganRamenBuilder : IRamenBuilder
    {
        private BrothType broth;
        private Noodles noodles;
        private List<Topping> toppings = new List<Topping>();
        private List<Extra> extras = new List<Extra>();

        public void SetBroth()
        {
            this.broth = BrothType.Vegan;
        }

        public void SetNoodles()
        {
            this.noodles = Noodles.Soba;
        }

        public void AddToppings()
        {
            toppings.Add(Topping.BambooShoots);
            toppings.Add(Topping.Seaweed);
        }

        public void AddExtras()
        {

        }

        public RamenBowls GetRamen()
        {
            RamenBowls vegan = new RamenBowls(broth, noodles, toppings, extras);
            return vegan;
        }
    }
}