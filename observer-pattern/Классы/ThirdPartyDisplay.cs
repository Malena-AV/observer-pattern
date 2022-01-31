using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    class ThirdPartyDisplay: Observer, DisplayElement
    {
        public void Update(float temp, float humidity, float pressure)
        {

        }
        public string Display()
        {
            return "weft";
        }
    }
}
