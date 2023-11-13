using System;

namespace Observer
{
    public class WeatherData : Subject
    {
        private List<Observer> observerList;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observerList = new List<Observer>();
        }

        public override void RegisterObserver(Observer obs)
        {
            observerList.Add(obs);
            obs.Update(temperature, humidity, pressure);
        }

        public override void RemoveObserver(Observer obs)
        {
            observerList.Remove(obs);
        }

        public override void NotifyObserver()
        {
            int count = observerList.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Observer receiver = observerList[i];
                    receiver.Update(temperature, humidity, pressure);
                }
            }
        }

        public void SetMeasurement(float temp, float humidity, float pressure)
        {
            this.humidity = humidity;
            this.temperature = temp;
            this.pressure = pressure;
            NotifyObserver();
        }
    }
}