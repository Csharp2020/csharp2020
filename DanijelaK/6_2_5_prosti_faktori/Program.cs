using System;
using System.Collections.Generic;

namespace _6_2_5_prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prirodni = new List<int>(1);
            int broj;

            broj = int.Parse(Console.ReadLine());
            int faktor = 2;
            while (faktor <= broj) ;
            {
                if (broj % faktor == 0)
                {
                    prirodni.Add(faktor);
                    broj /= faktor;
                }

                else
                {
                    faktor++;
                }
            }

            for (int i = 0; i < prirodni.Count; i++)
            {
                Console.Write(prirodni[i]);
                if (i<prirodni.Count-1)
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine();

            foreach (var item in prirodni)
            {
                Console.Write(item +" * ");
            }

        }
    }
}
