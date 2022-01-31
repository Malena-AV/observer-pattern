using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    class ForecastDisplay: Observer, DisplayElement
    {
        private float temp;
        private float humidity;
        private float pressure;
        private Subject WeatherData;

        public void Update(float temp, float humidity, float pressure)
        {

        }
        public string Display()
        {
            return "dfrg";
        }
    }
}
