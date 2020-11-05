using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int s = 0;

            while (i<=10)
            {
                s = s + i;
                i = i + 1;
                Console.WriteLine("Aktualna wartość i po zakończeniu przebiegu pętli: {0}", i);
                Console.WriteLine("Aktualna wartość s po zakończeniu przebiegu pętli: {0}", s);
                Console.WriteLine();
            }

            // 1 + 2 + 3 + 4 + ... + 10 = 55

            Console.ReadKey();
        }
    }
}
