using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Библиотека;

namespace Наблюдатель
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData Sub = new WeatherData();
            CurrentConditionsDisplay Obs1 = new CurrentConditionsDisplay(Sub);

        }
    }
}
