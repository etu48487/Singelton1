namespace Strategy
{
    public class EmperorPenguin : Bird
    {
        public EmperorPenguin()
        {
            movementBehavior = new Slide();
            this.name = "Emperor Penguin";
        }
    }
}