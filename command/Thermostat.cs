namespace command
{
    public class Thermostat
    {
        int temperature = 0;

        public void IncreaseTemperature()
        {
            this.temperature += 1;
        }
        public void DecreaseTemperature()
        {
            this.temperature -= 1;
        }
        public void DisplayTemperature()
        {
            Console.WriteLine("thermostat temperature : " + temperature);
        }
    }
}