using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        double temper;
        double humidity;
        double pressure;

        public void Update(double forecastemper, double forecashumidity, double forecaspressure, double temp, double humidity, double pressure, double maxtemp, double srtemp, double mintemp, double maxhum, double srhum, double minhum, double maxpr, double srpr, double minpr)
        {
            this.temper = temp;
            this.humidity = humidity;
            this.pressure = pressure;
        }
        public string Display()
        {
            return "Температура: " + temper + "Влажность: " + humidity + "Давление: " + pressure;
        }
    }
}
