namespace Builder
{
    public interface IRamenBuilder
    {
        void SetBroth();
        void SetNoodles();
        void AddToppings();
        void AddExtras();

        RamenBowls GetRamen();
    }
}