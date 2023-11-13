using System;

namespace Observer
{
    class Main
    {
        static void Main(string[] args)
        {
            WeatherData relay = new WeatherData();
            CurrentConditionDisplay dis1 = new CurrentConditionDisplay();
            StatisticDisplay dis2 = new StatisticDisplay();
            ForecastDisplay dis3 = new ForecastDisplay();
        
            relay.SetMeasurment(1, 1, 1);
            relay.RegisterObserver(dis2);
            relay.RegisterObserver(dis1);
            dis1.DisplayElement();
            dis2.DisplayElement();
            relay.SetMeasurment(25, 56, 90);
            relay.RegisterObserver(dis3);
        }
    }
}