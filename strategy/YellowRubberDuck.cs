using System;

namespace Strategy
{
    public class YellowRubberDuck : Bird
    {
        public YellowRubberDuck()
        {
            MovementBehavior = new Floats();
            this.Name = "Yellow Rubber Duck's";
        }
    }
}