namespace Command
{
    public class CombinedOnCommand : Command
    {
        private Light light;
        private Thermostat thermostat;

        public CombinedOnCommand(Light light, Thermostat thermostat)
        {
            this.light = light;
            this.thermostat = thermostat;
        }

        public void Execute()
        {
            light.On();
            thermostat.IncreaseTemperature();
            // TODO Auto-generated method stub
        }
    }
}