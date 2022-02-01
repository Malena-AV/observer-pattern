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

        public void Update(float temp, float humidity, float pressure, float maxtemp, float srtemp, float mintemp, float maxhum, float srhum, float minhum, float maxpr, float srpr, float minpr)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }
        public string Display()
        {
            return "Температура: " + temp + "Влажность: " + humidity + "Давление: " + pressure;
        }
    }
}
