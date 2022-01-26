using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ConcreteSubject : Subject
    {
        List<ConcreteObserver> observers = new List<ConcreteObserver> { };
        public void NotifyObservers()//уведомить
        {
            for (int i = 0; i < observers.Count; i++)
            {
               observers[i].Update();
            }
        }

        public void RegisterObserver(ConcreteObserver a)//зарегистрировать
        {
            observers.Add(a);
        }

        public void RemoveObserver(ConcreteObserver a)//удалить
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
