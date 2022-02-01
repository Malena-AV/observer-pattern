using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class StatisticsDisplay: Observer, DisplayElement
    {
        float maxtemp;
        float srtemp;
        float mintemp;
        float maxhum;
        float srhum;
        float minhum;
        float maxpr;
        float srpr;
        float minpr;

        public void Update(float temp, float humidity, float pressure, float maxtemp, float srtemp, float mintemp, float maxhum, float srhum, float minhum, float maxpr, float srpr, float minpr)
        {
            this.maxtemp = maxtemp;
            this.srtemp = srtemp;
            this.mintemp = mintemp;
            this.maxhum = maxhum;
            this.srhum = srhum;
            this.minhum = minhum;
            this.maxpr = maxpr;
            this.srpr = srpr;
            this.minpr = minpr;
        }

        readonly List<float> temp = new List<float> { 12, 4, 32 };
        public void Temp()
        {
            float sum = 0;
            for (int i = 0; i < temp.Count; i++)
            {
               maxtemp = temp.Max();
               mintemp = temp.Min();
               sum+= temp[i];
            }
            srtemp = (sum / temp.Count);
        }

        readonly List<float> humidity = new List<float> { 50, 290, 62 };
        public void Humidity()
        {
            float sum = 0;
            for (int i = 0; i < humidity.Count; i++)
            {
                maxhum = humidity.Max();
                minhum = humidity.Min();
                sum += humidity[i];
            }
            srtemp = (sum / humidity.Count);
        }

        readonly List<float> pressure = new List<float> { 9, 45, 81 };
        public void Pressyre()
        {
            float sum = 0;
            for (int i = 0; i < pressure.Count; i++)
            {
                maxpr = pressure.Max();
                minpr = pressure.Min();
                sum += pressure[i];
            }
            srtemp = (sum / pressure.Count);
        }
        public string Display()
        {
            return "макимальная температура" + maxtemp +
                   "средняя температура" + srtemp +
                   "минимальнаяя температура" + mintemp + 
                   "максимальная влажность" + maxhum +
                   "средняя влажность" + srhum +
                   "минимальная влажность" + minhum +
                   "максимальное давление" +  maxpr +
                   "среднее давление" + srpr +
                   "минимальное давление" + minpr; ;
        }
    }
}
