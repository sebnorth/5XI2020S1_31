using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku trójkąta: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("{0} ", j*(i+1));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
