using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class WeatherData : Subject
    {
        float temp;
        float humidity;
        float pressure;
        float maxtemp;
        float srtemp;
        float mintemp;
        float maxhum;
        float srhum;
        float minhum;
        float maxpr;
        float srpr;
        float minpr;

        List<Observer> observers = new List<Observer> { };
        public WeatherData()
        {
            observers = new List<Observer> { };
        }
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update(temp, humidity, pressure, maxtemp, srtemp, mintemp, maxhum, srhum, minhum, maxpr, srpr, minpr);
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
        public void Measurements(float temperature, float humidity, float pressure)
        {
            this.temp = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public void CurrentTemperature(float temper)
        {
            temp = temper;
        }
        public void CurrentHumidity(float hum)
        {
            humidity = hum;
        }
        public void CurrentPressure(float press)
        {
            pressure = press;
        }
        public void StatisticTemperature(float max, float sr, float min)
        {
            maxtemp = max;
            srtemp = sr;
            mintemp = min;
        }
        public void StatisticHumidity(float max, float sr, float min)
        {
            maxtemp = max;
            srtemp = sr;
            mintemp = min;
        }
        public void StatisticPressure(float max, float sr, float min)
        {
            maxtemp = max;
            srtemp = sr;
            mintemp = min;
        }
        public void ForecasTemperature(float temper)
        {
            temp = temper;
        }
        public void ForecasHumidity(float hum)
        {
            humidity = hum;
        }
        public void ForecasPressure(float press)
        {
            pressure = press;
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
