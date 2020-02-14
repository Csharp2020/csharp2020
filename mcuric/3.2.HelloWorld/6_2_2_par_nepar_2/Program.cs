using System;
using System.Collections;
using System.Collections.Generic;

namespace _6_2_2_par_nepar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 10 prirodnih brojeva: ");
            List<int> arr = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }
            List<int> arr_parni = new List<int>();
            List<int> arr_neparni = new List<int>();

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    arr_parni.Add(item);
                }
                else
                {
                    arr_neparni.Add(item);
                }
            }
            Console.WriteLine("Parni brojevi vase liste su: ");
            foreach (var item in arr_parni)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Neparni brojevi vase liste su: ");
            foreach (var item in arr_neparni)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
