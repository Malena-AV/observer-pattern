using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class WeatherData : Subject
    {
        private float temp;
        private float humidity;
        private float pressure;
        List<Observer> observers = new List<Observer> { };
        public WeatherData()
        {
            observers = new List<Observer> { };
        }
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update(temp, humidity, pressure);
            }
        }
        List<WeatherData> temper = new List<WeatherData> { };
        public void PlusTemp(float a)
        {
                

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

        public float GetTemperature(float a)
        {
            temp = a;
            return temp;
        }
        public float GetHumidity(float a)
        {
            humidity = a;
            return humidity;
        }
        public float GetPressure(float a)
        {
            pressure = a;
            return pressure;
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
