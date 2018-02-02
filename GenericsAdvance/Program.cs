using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("pred {0}, {1}", a, b);
            Swapper.Swap<int>(ref a, ref b);

            Console.WriteLine("po {0},{1}",a, b);
            

            string s1 = "Ahoj";
            string s2 = "Cau";

            Console.WriteLine("pred {0},{1}", s1, s2);
            Swapper.Swap<string>(ref s1, ref s2);

            Console.WriteLine("po {0},{1}", s1, s2);

            Nakladak n1 = new Nakladak { VykonMotora = 100 };
            Nakladak n2 = new Nakladak { VykonMotora = 50 };
            Osobak o1 = new Osobak { VykonMotora = 150 };
            Osobak o2 = new Osobak { VykonMotora = 200 };

            Console.WriteLine("Vykony nakladakov pred {0},{1}", n1.VykonMotora, n2.VykonMotora);
            Console.WriteLine("Vykony osobakov pred {0},{1}", o1.VykonMotora, o2.VykonMotora);

            SpravcaAut<Nakladak> spravcaNakladakov = new SpravcaAut<Nakladak>();
            SpravcaAut<Osobak> spravcaOsobakov = new SpravcaAut<Osobak>();
            spravcaOsobakov.PrehodMotory(o1, o2);
            spravcaNakladakov.PrehodMotory(n1, n2);

            Console.WriteLine("Vykony nakladakov po {0},{1}", n1.VykonMotora, n2.VykonMotora);
            Console.WriteLine("Vykony osobakov po {0},{1}", o1.VykonMotora, o2.VykonMotora);
            Console.ReadKey();


        }
    }
}
