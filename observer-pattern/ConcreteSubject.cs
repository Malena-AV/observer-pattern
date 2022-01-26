using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ConcreteSubject : Subject
    {
        List<ConcreteObserver> observer = new List<ConcreteObserver> { };
        public void NotifyObservers()//уведомить
        {
            for (int i = 0; i < observer.Count; i++)
            {
               observer[i].Update();
            }
        }

        public void RegisterObserver(ConcreteObserver a)//зарегестрировать
        {
            observer.Add(a);
        }

        public void RemoveObserver(ConcreteObserver a)//удалить
        {
            observer.Remove(a);
        }

        string state;
        public string State
        {
            get { return state; }
            set { state = value; NotifyObservers(); }
        }
    }
}
