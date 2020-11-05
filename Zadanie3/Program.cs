using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj n:");
            int n = int.Parse(Console.ReadLine());
            
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i;

            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
