using System;

namespace Strategy
{
    public class Ostrich : Bird
    {
        public Ostrich()
        {
            movementBehavior = new CannotFly();
            this.name = "Ostrich's";
        }
    }
}