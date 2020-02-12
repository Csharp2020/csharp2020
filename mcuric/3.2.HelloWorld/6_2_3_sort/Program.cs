using System;
using System.Collections.Generic;

namespace _6_2_3_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodne brojeve, u trenutku kad vam ih je dovoljno unesite nulu");

            List<int> prirodni = new List<int>();
            int unos;
            do
            {
                unos = int.Parse(Console.ReadLine());
                prirodni.Add(unos);
            } while (unos != 0);
            prirodni.Sort();
            prirodni.Remove(0);
            
            Console.WriteLine("Vasa sortirana lista izgleda ovako: ");
            foreach (var item in prirodni)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}
