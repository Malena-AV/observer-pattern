using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface Observer
    {
        void Update(float temp, float humidity, float pressure, float maxtemp, float srtemp, float mintemp, float maxhum, float srhum, float minhum, float maxpr, float srpr, float minpr);
    }
}
