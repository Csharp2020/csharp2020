using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._2._5_prostiFaktori
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            List<int> djelitelji = new List<int>();
            int k = 2;

            for (int i = 0; i < x; i++)
            {
                if (x % k == 0)
                {
                    djelitelji.Add(k);
                    x = x / k;
                }
                else
                {
                    k++;
                }
            }

            foreach (var item in djelitelji)
            {
                Console.Write(item + " * ");
            }
        }
    }
}
