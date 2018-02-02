using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvance
{
    abstract class Auto
    {
        public int VykonMotora
        {
            get;
                  
            set;
                      
        }

        public void VypisVykon()
        {
            Console.WriteLine("Vykon motora je{0}", VykonMotora);
        }
    }
}
