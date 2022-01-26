using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface Subject
    {
        void RegisterObserver(ConcreteObserver a);
        void RemoveObserver(ConcreteObserver a);
        void NotifyObservers();

    }
}
