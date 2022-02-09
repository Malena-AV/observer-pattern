using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class WeatherData : ISubject
    {
        double temper;
        double humidity;
        double pressure;

        double maxtemp = double.NaN;
        double averagetemp;
        double mintemp = double.NaN;

        double maxhum = double.NaN;
        double averagehum;
        double minhum = double.NaN;

        double maxpr = double.NaN;
        double averagepr;
        double minpr = double.NaN;

        readonly List<IObserver> observers = new List<IObserver> { };
        public WeatherData()
        {
            observers = new List<IObserver> { };
        }
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update(temper, humidity, pressure, maxtemp, averagetemp,
            mintemp, maxhum, averagehum, minhum, maxpr, averagepr, minpr);
            }
        }

        public void RegisterObserver(IObserver a)
        {
            observers.Add(a);
        }

        public void RemoveObserver(IObserver a)
        {
            int i = observers.IndexOf(a);
            if (i >= 0)
            {
                observers.Remove(a);
            }
        }
        public void CurrentTemperature(double newtemper)
        {
            temper = newtemper;
            Temp(newtemper);
            MeasurementsChanged();
        }
        public void CurrentHumidity(double newhumidity)
        {
            humidity = newhumidity;
            Humidity(newhumidity);
            MeasurementsChanged();
        }
        public void CurrentPressure(double newpressure)
        {
            pressure = newpressure;
            Pressure(newpressure);
            MeasurementsChanged();
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }


        void Temp(double newTemp)
        {
            if (double.IsNaN(mintemp))
            {
                mintemp = newTemp;
            }

            else if (mintemp > newTemp)
            {
                mintemp = newTemp;
            }

            if (double.IsNaN(maxtemp))
            {
                maxtemp = newTemp;
            }
            else if (maxtemp < newTemp)
            {
                maxtemp = newTemp;
            }

            averagetemp = (mintemp + maxtemp) / 2;
        }
        void Humidity(double newHum)
        {
            if (double.IsNaN(minhum))
            {
                minhum = newHum;
            }

            else if (minhum > newHum)
            {
                minhum = newHum;
            }

            if (double.IsNaN(maxhum))
            {
                maxhum = newHum;
            }
            else if (maxhum < newHum)
            {
                maxhum = newHum;
            }

            averagehum = (minhum + maxhum) / 2;
        }
        void Pressure(double newPr)
        {
            if (double.IsNaN(minpr))
            {
                minpr = newPr;
            }

            else if (minpr > newPr)
            {
                minpr = newPr;
            }

            if (double.IsNaN(maxpr))
            {
                maxpr = newPr;
            }
            else if (maxpr < newPr)
            {
                maxpr = newPr;
            }

            averagepr = (minpr + maxpr) / 2;
        }
    }
}
