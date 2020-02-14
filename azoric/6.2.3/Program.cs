using System;
using System.Collections.Generic;

namespace _6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> prirodni = new List<int>();
            int broj;
            do
            {

                broj = int.Parse(Console.ReadLine());
                prirodni.Add(broj);

            } while (broj != 0);

            prirodni.Sort();
            foreach (var item in prirodni)
            {
                Console.Write(item + " ");
            }
        }
    }
}
