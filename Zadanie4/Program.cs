﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b:");
            int b = int.Parse(Console.ReadLine());

            if (a>b)
            {
                int c = a;

                a = b;

                b = c; 
            }

            if (a % 2 == 1) a += 1;

            for (int i = a; i <= b; i = i + 2)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadKey();
        }
    }
}
