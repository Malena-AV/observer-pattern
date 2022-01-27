using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ConcreteSubject : Subject
    {
        List<Observer> observers = new List<Observer> { };
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update();
            }
        }

        public void RegisterObserver(Observer a)
        {
            observers.Add(a);
        }

        public void RemoveObserver(Observer a)
        {
            observers.Remove(a);
        }

        string state;
        public string State
        {
            get { return state; }
            set { state = value; NotifyObservers(); }
        }
    }
}
