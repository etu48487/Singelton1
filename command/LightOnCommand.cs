namespace Command
{
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public override void execute()
        {
            light.on();
            // TODO Auto-generated method stub
        }
    }
}