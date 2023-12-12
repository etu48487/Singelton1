using System;
using System.Collections.Generic;

namespace Builder
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private BrothType broth;
        private Noodles noodles;
        private List<Topping> toppings = new List<Topping>();
        private List<Extra> extras = new List<Extra>();

        public void SetBroth()
        {
            this.broth = BrothType.SpicyTonkotsu;
        }

        public void SetNoodles()
        {
            this.noodles = Noodles.Thin;
        }

        public void AddToppings()
        {
            toppings.Add(Topping.GreenOnions);
            toppings.Add(Topping.ChashuPork);
        }

        public void AddExtras()
        {
            extras.Add(Extra.ExtraSpice);
        }

        public RamenBowls GetRamen()
        {
            RamenBowls spicy = new RamenBowls(broth, noodles, toppings, extras);
            return spicy;
        }
    }
}