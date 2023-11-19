namespace Strategy
{
    public class MallardDuck : Bird
    {
        public MallardDuck()
        {
            MovementBehavior = new Fly();
            this.Name = "Mallard Duck's";
        }
    }
}