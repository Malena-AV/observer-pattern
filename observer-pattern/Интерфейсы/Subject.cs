using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public interface Subject
    {
        void RegisterObserver(Observer a);
        void RemoveObserver(Observer a);
        void NotifyObservers();

    }
}
