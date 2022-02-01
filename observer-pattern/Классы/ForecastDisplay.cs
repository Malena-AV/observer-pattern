using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ForecastDisplay: Observer, DisplayElement
    {
        double Ftemper;
        double Fhumidity;
        double Fpressure;

        public void Update(double forecastemper, double forecashumidity, double forecaspressure, double temp, double humidity, double pressure, double maxtemp, double srtemp, double mintemp, double maxhum, double srhum, double minhum, double maxpr, double srpr, double minpr)
        {
            Ftemper = forecastemper;
            Fhumidity = forecashumidity;
            Fpressure = forecaspressure;
        }

        private void ProgTemp()
        {
            Random x = new Random();
            Ftemper = x.Next(-100, 100);
        }
        private void ProgHum()
        {
            Random x = new Random();
            Fhumidity = x.Next(-100, 100);
        }
        private void ProgPreg()
        {
            Random y = new Random();
            Fpressure = y.Next(-100, 100);
        }

        public string Display()
        {
            return "прогноз температуры: " + Ftemper +
                   "прогноз влажности: " + Fhumidity +
                   "прогноз давления: " + Fpressure;
        }
    }
}
