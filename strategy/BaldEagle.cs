namespace strategy
{
    public class BaldEagle : Bird
    {
        public BaldEagle()
        {
            movementBehavior = new Fly();
            this.name = "Bald Eagle's";
        }
    }
}