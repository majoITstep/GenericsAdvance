using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvance
{
    class Swapper
    {
        public static void Swap<T>(ref T a, ref T b)
//davam ref aby kazda premenna bola odovzdana odkazom
// aby napln funkcie ovplyvnil povodne premenne
        {
            T temp = a;
            a = b;
            b = temp;
            
        }

    }
}
