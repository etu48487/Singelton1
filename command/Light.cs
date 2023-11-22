namespace command
{
    public class Light
    {
        bool inFunction = false;

        void on()
        {
            this.inFunction = true;
            displayLampStatus();
        }
        void off()
        {
            this.inFunction = false;
            displayLampStatus();
        }
        void displayLampStatus()
        {
            if (inFunction) { Console.WriteLine("light is on"); }
            else Console.WriteLine("light is off");

        }
    }
}