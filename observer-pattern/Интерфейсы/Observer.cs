using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface Observer
    {
        void Update(double forecastemper, double forecashumidity, double forecaspressure, double temp, double humidity, double pressure, double maxtemp, double srtemp, double mintemp, double maxhum, double srhum, double minhum, double maxpr, double srpr, double minpr);
    }
}
