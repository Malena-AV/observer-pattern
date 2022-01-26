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
            ConcreteSubject Sub = new ConcreteSubject();
            ConcreteObserver Obs1 = new ConcreteObserver();
            ConcreteObserver Obs2 = new ConcreteObserver();

            Sub.RegisterObserver(Obs1);
            Sub.State = "aa";
            Console.WriteLine(Obs1.Counter);
            Console.WriteLine(Obs2.Counter);

            Sub.RegisterObserver(Obs2);
            Sub.State = "bb";
            Console.WriteLine(Obs1.Counter);
            Console.WriteLine(Obs2.Counter);

            Sub.RemoveObserver(Obs2);
            Sub.State = "cc";
            Console.WriteLine(Obs1.Counter);
            Console.WriteLine(Obs2.Counter);
            Console.ReadKey();
        }
    }
}
