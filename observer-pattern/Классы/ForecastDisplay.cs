using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ForecastDisplay: Observer, DisplayElement
    {
        private float temper;
        private float humidity;
        private float pressure;


        public void Update(float temp, float humidity, float pressure, float maxtemp, float srtemp, float mintemp, float maxhum, float srhum, float minhum, float maxpr, float srpr, float minpr)
        {
            this.temper = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }

       private void ProgTemp()
        {
            Random x = new Random();
            temper = x.Next(-100, 100);
        }
        private void ProgHum()
        {
            Random x = new Random();
            humidity = x.Next(-100, 100);
        }
        private void ProgPreg()
        {
            Random x = new Random();
            temper = x.Next(-100, 100);
        }

        public string Display()
        {
            return "прогноз температуры: " + temper +
                   "прогноз влажности: " + humidity +
                   "прогноз давления: " + pressure;
        }
    }
}
