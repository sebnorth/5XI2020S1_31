﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                suma += i;

            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
