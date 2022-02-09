using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class StatisticsDisplay: IObserver, IDisplayElement
    {

        double maxtemp;
        double averagetemp;
        double mintemp;

        double maxhum;
        double averagehum;
        double minhum;

        double maxpr;
        double averagepr;
        double minpr;

        public void Update(double temp, double humidity, double pressure, double maxtemp, double averagetemp,
            double mintemp, double maxhum, double averagehum, double minhum, double maxpr, double averagepr, double minpr)
        {
            this.maxtemp = maxtemp;
            this.averagetemp = averagetemp;
            this.mintemp = mintemp;

            this.maxhum = maxhum;
            this.averagehum = averagehum;
            this.minhum = minhum;

            this.maxpr = maxpr;
            this.averagepr = averagepr;
            this.minpr = minpr;
        }

        public string Display()
        {
            return "макимальная температура " + maxtemp +
                   "\nсредняя температура " + averagetemp +
                   "\nминимальнаяя температура " + mintemp +
                   "\nминимальнаяя температура " + mintemp +
                   "\nмаксимальная влажность " + maxhum +
                   "\nсредняя влажность " + averagehum +
                   "\nминимальная влажность " + minhum +
                   "\nмаксимальное давление " +  maxpr +
                   "\nсреднее давление " + averagepr +
                   "\nминимальное давление " + minpr; ;
        }
    }
}
