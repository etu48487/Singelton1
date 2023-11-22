namespace command
{
    public class CombinedOffCommand : Command
    {
        private Light light;
        private Thermostat thermostat;

        public CombinedOffCommand(Light light, Thermostat thermostat)
        {
            this.light = light;
            this.thermostat = thermostat;
        }

        public void execute()
        {
            light.off();
            thermostat.decreaseTemperature();
            // TODO Auto-generated method stub
        }
    }
}