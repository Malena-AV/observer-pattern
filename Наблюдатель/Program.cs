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

            ForecastDisplay fd = new ForecastDisplay();
            Sub.RegisterObserver(fd);
            Console.WriteLine(fd.Display());
            CurrentConditionsDisplay cd = new CurrentConditionsDisplay();
            Sub.RegisterObserver(cd);
            Console.WriteLine(cd.Display());
            CurrentConditionsDisplay cd = new CurrentConditionsDisplay();
            Sub.RegisterObserver(cd);
            Console.WriteLine(cd.Display());
            Console.ReadKey();


        }
    }
}
