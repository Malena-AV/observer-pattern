using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class WeatherData : Subject
    {
        double temper;
        double humidity;
        double pressure;
        double maxtemp;
        double srtemp;
        double mintemp;
        double maxhum;
        double srhum;
        double minhum;
        double maxpr;
        double srpr;
        double minpr;
        double forecastemper;
        double forecashumidity;
        double forecaspressure;

        List<Observer> observers = new List<Observer> { };
        public WeatherData()
        {
            observers = new List<Observer> { };
        }
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update(temper, humidity, pressure, maxtemp, srtemp, mintemp, maxhum, srhum, minhum, maxpr, srpr, minpr, forecastemper, forecashumidity, forecaspressure);
            }
        }

        public void RegisterObserver(Observer a)
        {
            observers.Add(a);
        }

        public void RemoveObserver(Observer a)
        {
            int i = observers.IndexOf(a);
            if (i >= 0)
            {
                observers.Remove(a);
            }
        }

        public void CurrentTemperature(double temper)
        {
            this.temper = temper;
            StatisticsDisplay statistics = new StatisticsDisplay();
            statistics.Temp(temper);
            MeasurementsChanged();
        }
        public void CurrentHumidity(double humidity)
        {
            this.humidity = humidity;
            StatisticsDisplay statistics = new StatisticsDisplay();
            statistics.Humidity(humidity);
            MeasurementsChanged();
        }
        public void CurrentPressure(double pressure)
        {
            this.pressure = pressure;
            StatisticsDisplay statistics = new StatisticsDisplay();
            statistics.Pressyre(pressure);
            MeasurementsChanged();
        }

        //public void StatisticTemperature(double max, double sr, double min)
        //{
        //    maxtemp = max;
        //    srtemp = sr;
        //    mintemp = min;
        //}
        //public void StatisticHumidity(double max, double sr, double min)
        //{
        //    maxhum = max;
        //    srhum = sr;
        //    minhum = min;
        //}
        //public void StatisticPressure(double max, double sr, double min)
        //{
        //    maxpr = max;
        //    srpr = sr;
        //    minpr = min;
        //}
        //public void ForecasTemperature(double temper)
        //{
        //    forecastemper = temper;
        //    MeasurementsChanged();
        //}
        //public void ForecasHumidity(double hum)
        //{
        //    forecashumidity = hum;
        //    MeasurementsChanged();
        //}
        //public void ForecasPressure(double press)
        //{
        //    forecaspressure = press;
        //    MeasurementsChanged();
        //}
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
