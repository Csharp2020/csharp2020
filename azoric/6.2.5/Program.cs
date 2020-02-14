using System;
using System.Collections;

namespace _6._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            int prirodanbroj = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList();
            while (prirodanbroj > 0)
            {
                arr.Add(prirodanbroj % 10);
                prirodanbroj /= 10;
            }
            Console.WriteLine("napoako");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);

            }
            Console.ReadKey();
        }
    }
}
