namespace command
{
    public class ThermostatIncreaseCommand : Command
    {
        private Thermostat thermostat;

        public ThermostatIncreaseCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void execute()
        {
            // TODO Auto-generated method stub
            thermostat.increaseTemperature();
        }
    }
}