using System.Collections.Generic;

namespace Builder
{
    public class RamenBowls
    {
        private readonly BrothType broth;
        private Noodles noodles;
        private List<Topping> toppings;
        private List<Extra> extras;

        public RamenBowls(BrothType broth, Noodles noodles, List<Topping> toppings, List<Extra> extras)
        {
            this.broth = broth;
            this.noodles = noodles;
            this.toppings = toppings;
            this.extras = extras;
        }
        public string FinishedBowlOfRamen()
        {
            string info;
            info = "Content of the Ramen Bowl : ";
            info += ("\n Broth type : " + broth);
            info += ("\n Noodles type : " + noodles);
            if (!toppings.IsEmpty())
            {
                info += "\n Toppings list :";
                for (int i = 0; i < toppings.Count(); i++)
                {
                    info += " ";
                    info += (toppings.ElementAt(i));
                }
            }
            else
            {
                info += "\n No Toppings";
            }
            if (!extras.IsEmpty())
            {
                info += "\n Extra list :";
                for (int i = 0; i < extras.Count(); i++)
                {
                    info += " ";
                    info += (extras.ElementAt(i));
                }
            }
            else
            {
                info += "\n no extras";
            }
            return info;
        }
    }
}