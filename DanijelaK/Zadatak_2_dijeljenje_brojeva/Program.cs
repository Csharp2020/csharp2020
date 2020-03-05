using System;
using System.Collections.Generic;

namespace Zadatak_2_dijeljenje_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            int broj = -1;

            while (broj != 0)
            {
                Console.WriteLine("Unesite broj:");
                broj = int.Parse(Console.ReadLine());
                brojevi.Add(broj);
            }

            Console.WriteLine("--------Brojevi djeljivi s 2 i 3: --------");
            foreach (var item in brojevi)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    Console.WriteLine(item);
                  
                }
            }
          
            Console.WriteLine("--------Brojevi djeljivi s 2, ali ne sa 3: --------");

            foreach (var item in brojevi)
            {
                if (item % 2 == 0 && item % 3 != 0)
                {
                    Console.WriteLine(item);

                }
            }

            Console.WriteLine("--------Brojevi djeljivi s 3, ali ne sa 2: --------");

            foreach (var item in brojevi)
            {
                if (item % 2 != 0 && item % 3== 0)
                {
                    Console.WriteLine(item);
                }
            }
            List<int> ostalibBrojevi = new List<int>();


            Console.WriteLine("--------Ostali brojevi: --------");
            foreach (var item in ostalibBrojevi)
            {
                if (!(item % 2 == 0 && item % 3 == 0 || item % 2 == 0 && item % 3 != 0 || item % 2 != 0 && item % 3 == 0))
                {
                    ostalibBrojevi.Add(item);
                    Console.WriteLine(item);
                }
                

            }

        }
    }
}
