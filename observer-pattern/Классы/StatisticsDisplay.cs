using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class StatisticsDisplay: Observer, DisplayElement
    {

        double Smaxtemp;
        double Ssrtemp;
        double Smintemp;
        double Smaxhum;
        double Ssrhum;
        double Sminhum;
        double Smaxpr;
        double Ssrpr;
        double Sminpr;

        public void Update(double forecastemper, double forecashumidity, double forecaspressure, double temp, double humidity, double pressure, double maxtemp, double srtemp, double mintemp, double maxhum, double srhum, double minhum, double maxpr, double srpr, double minpr)
        {
            Smaxtemp = maxtemp;
            Ssrtemp = srtemp;
            Smintemp = mintemp;
            Smaxhum = maxhum;
            Ssrhum = srhum;
            Sminhum = minhum;
            Smaxpr = maxpr;
            Ssrpr = srpr;
            Sminpr = minpr;

        }

        readonly List<double> temp = new List<double> {};
        public void Temp(double t)
        {
            double sum = 0;
            for (int i = 0; i < temp.Count; i++)
            {
               temp.Add(t);
               Smaxtemp = temp.Max();
               Smintemp = temp.Min();
               sum+= temp[i];
            }
            Ssrtemp = (sum / temp.Count);
        }

        readonly List<double> Lhumidity = new List<double> {};
        public void Humidity (double h)
        {
            double sum = 0;
            for (int i = 0; i < Lhumidity.Count; i++)
            {
                Lhumidity.Add(h);
                Smaxhum = Lhumidity.Max();
                Sminhum = Lhumidity.Min();
                sum += Lhumidity[i];
            }
            Ssrhum = (sum / Lhumidity.Count);
        }

        readonly List<double> Lpressure = new List<double> {};
        public void Pressyre(double p)
        {
            double sum = 0;
            for (int i = 0; i < Lpressure.Count; i++)
            {
                Lpressure.Add(p);
                Smaxpr = Lpressure.Max();
                Sminpr = Lpressure.Min();
                sum += Lpressure[i];
            }
            Ssrpr = (sum / Lpressure.Count);
        }

        public string Display()
        {
            return "макимальная температура " + Smaxtemp +
                   "\nсредняя температура " + Ssrtemp +
                   "\nминимальнаяя температура " + Smintemp +
                   "\nминимальнаяя температура " + Smintemp +
                   "\nмаксимальная влажность " + Smaxhum +
                   "\nсредняя влажность " + Ssrhum +
                   "\nминимальная влажность " + Sminhum +
                   "\nмаксимальное давление " +  Smaxpr +
                   "\nсреднее давление " + Ssrpr +
                   "\nминимальное давление " + Sminpr; ;
        }
    }
}
