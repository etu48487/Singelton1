namespace Builder
{
    public class RamenChef
    {
        public RamenBowls PrepareRamen(IRamenBuilder builder)
        {
            builder.SetBroth();
            builder.SetNoodles();
            builder.AddToppings();
            builder.AddExtras();
            RamenBowls ramen = builder.GetRamen();
            //TODO#1: Call each builder step declared in RamenBuilder class

            return ramen;
        }
    }
}