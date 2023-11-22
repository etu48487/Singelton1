namespace command
{
    public class ThermostatDecreaseCommand : Command
    {
        private Thermostat thermostat;

        public ThermostatDecreaseCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void execute()
        {
            // TODO Auto-generated method stub
            thermostat.DecreaseTemperature();
        }
    }
}