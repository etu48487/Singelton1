using System.Collections.Generic;

namespace RamenBuilder
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        private BrothType broth;
        private Noodles noodles;
        private List<Topping> toppings = new List<Topping>();
        private List<Extra> extras = new List<Extra>();

        public void SetBroth()
        {
            this.broth = BrothType.Miso;
        }

        public void SetNoodles()
        {
            this.noodles = Noodles.Udon;
        }

        public void AddToppings()
        {
            toppings.Add(Topping.GreenOnions);
        }

        public void AddExtras()
        {
            extras.Add(Extra.Corn);
        }

        public RamenBowls GetRamen()
        {
            RamenBowls miso = new RamenBowls(broth, noodles, toppings, extras);
            return miso;
        }
    }
}