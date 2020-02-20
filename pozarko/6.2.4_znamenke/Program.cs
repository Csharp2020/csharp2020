using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._2._4_znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prirodniBroj = new List<int>();
            Console.WriteLine("Unesite prirodan broj");
            int x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                prirodniBroj.Add(x%10);
                x = x / 10;
            }

            foreach (var item in prirodniBroj)
            {
                Console.Write(item);
            }
        }
    }
}
