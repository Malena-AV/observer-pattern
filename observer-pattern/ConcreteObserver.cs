using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class ConcreteObserver : Observer
    {
        int counter = 0;
        public int Counter { get { return counter; } }
        public void Update()
        {
            counter++;
        }
    }
}
