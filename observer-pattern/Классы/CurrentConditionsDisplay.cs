using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temp;
        private float humidity;
        private float pressure;
        private Subject WeatherData;

        public CurrentConditionsDisplay(Subject WeatherData)
        {
            this.WeatherData = WeatherData;
            WeatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
        public string Display()
        {
            return "Температура: " + temp + "Влажность: " + humidity + "Давление: " + pressure;
        }
    }
}
