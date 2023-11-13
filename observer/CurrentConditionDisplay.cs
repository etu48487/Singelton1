namespace Observer
{
    public class CurrentConditionDisplay : Display, Observer
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.humidity = humidity;
            this.temperature = temperature;
            this.pressure = pressure;
            DisplayElement();
        }
        
        public void DisplayElement()
        {
            string message = "Display 1 Current condition";
            message += "\n Temperature : " + this.temperature;
            message += "\n Pressure : " + this.pressure;
            message += "\n Humidity percentage : " + this.humidity;
            Console.WriteLine(message);
        }
    }
}