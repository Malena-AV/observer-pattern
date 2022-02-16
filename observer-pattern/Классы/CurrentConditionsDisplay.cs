using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        double currenttemper;
        double currenthumidity;
        double currentpressure;

        public void Update(double temp, double humidity, double pressure, double maxtemp, double averagetemp,
            double mintemp, double maxhum, double averagehum, double minhum, double maxpr, double averagepr, double minpr)
        {
            currenttemper = temp;
            currenthumidity = humidity;
            currentpressure = pressure;
        }
        public string Display()
        {
            return "Температура: " + currenttemper + "\nВлажность: " + currenthumidity + "\nДавление: " + currentpressure;
        }
    }
}
