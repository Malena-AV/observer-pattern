using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ForecastDisplay: IObserver, IDisplayElement
    {
        double Ftemper;
        double Fhumidity;
        double Fpressure;
        readonly Random rnd = new Random();

        public void Update(double temp, double humidity, double pressure, double maxtemp, double averagetemp,
            double mintemp, double maxhum, double averagehum, double minhum, double maxpr, double averagepr, double minpr)
        {
            Ftemper = temp*(rnd.Next(5,15)/10.0);
            Fhumidity = humidity * (rnd.Next(5, 15) / 10.0);
            Fpressure = pressure * (rnd.Next(9, 11) / 10.0);
        }

        public string Display()
        {
            return "прогноз температуры: " + Ftemper +
                   "\nпрогноз влажности: " + Fhumidity +
                   "\nпрогноз давления: " + Fpressure;
        }
    }
}
