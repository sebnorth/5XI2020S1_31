using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<=1000)
            {
                Console.WriteLine("Weszliśmy do pętli while po raz {0}-ty", i);
                i = i + 1;
            }

            Console.ReadKey();
        }
    }
}
