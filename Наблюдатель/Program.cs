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

            CurrentConditionsDisplay cd = new CurrentConditionsDisplay();
            StatisticsDisplay sd = new StatisticsDisplay();
            ForecastDisplay fd = new ForecastDisplay();
           
            Sub.RegisterObserver(cd);
            Sub.RegisterObserver(sd);
            Sub.RegisterObserver(fd);

            Sub.CurrentTemperature(23);
            Sub.CurrentTemperature(100);
            Sub.CurrentHumidity(900);
            Sub.CurrentHumidity(500);

            Console.WriteLine(cd.Display());
            Console.WriteLine(sd.Display());
            Console.WriteLine(fd.Display());


            Console.ReadKey();


        }
    }
}
