using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure, double maxtemp, double averagetemp,
            double mintemp, double maxhum, double averagehum, double minhum, double maxpr, double averagepr, double minpr);
    }
}
