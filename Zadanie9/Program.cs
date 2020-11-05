using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            Console.WriteLine("Podaj wartość zmiennej n: ");
            int n = int.Parse(Console.ReadLine());

            // 1 + 3 + 5 + ... + ??? = 

            for (int i = 0; i < n-1; i++)
            {
                suma += (2 * i + 1);
                Console.Write("{0} + ", (2 * i + 1));
            }

            suma += (2 * (n-1) + 1);
            Console.Write("{0} ", (2 * (n-1) + 1));

            Console.Write("= {0}", suma);

            Console.ReadKey();

        }
    }
}
