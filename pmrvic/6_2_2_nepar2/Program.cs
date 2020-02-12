using System;
using System.Collections;
using System.Collections.Generic;

namespace _6_2_2_nepar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //treba napisati program koji ce traziti unos 10 elemenata
            //zatim ih razdvoji u parnu i neparnu listu
            Console.WriteLine("Unesite 10 elemenata!");
            List<int> arr = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }

            List<int> parni = new List<int>();
            List<int> neparni = new List<int>();

            foreach (var item in arr)
            {
                if (item % 2 == 0 )
                {
                    parni.Add(item);
                }
                else
                {
                    neparni.Add(item);
                }
            }

            //ispis parnih
            Console.WriteLine("Parni:");
            foreach (var item in parni)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine("Neparni:");
            foreach (var item in neparni)
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
