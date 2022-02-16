using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface ISubject
    {
        void RegisterObserver(IObserver a);
        void RemoveObserver(IObserver a);
        void NotifyObservers();

    }
}
