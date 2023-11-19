namespace Strategy
{
    public class Bird
    {
        private MovementBehavior _movementBehavior;
        private string _name;

        public void PerformMove()
        {
            string message = ("Here is the " + this._name + "movemement behavior: *" + _movementBehavior.Move() + "*");
            System.Console.WriteLine(message);
        }
    }
}