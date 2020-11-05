using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int janek = 50; // dzienny zarobek Janka

            int karol = 40; // dzienny zarobek Karola

            int dlug = 80; // wspólby dług Karola i Janka

            int suma = 0;

            int i = 1;

            do
            {
                
                suma += janek/5 + karol/5;
                Console.WriteLine("{0} {1}", i, suma);
                i++;
            } while (suma < dlug);

            Console.ReadKey();
        }
    }
}
