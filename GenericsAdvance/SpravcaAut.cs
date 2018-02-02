using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvance
{
    class SpravcaAut<T> where T : Auto
    {
        public void PrehodMotory(T auto1, T auto2)
        {
            int temp = auto1.VykonMotora;
            auto1.VykonMotora = auto2.VykonMotora;
            auto2.VykonMotora = temp;

        }

    }
}
