using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_2_5_prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            // unos broja te njegov rastav na proste faktore
            Console.WriteLine("Unesite prirodan broj n: ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            List<int> prosti_brojevi = new List<int>();
            List<int> prosti_faktori = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                    if (n % i == 0)
                    {
                        k++;
                    }
                    if (k == 2)
                    {
                        prosti_brojevi.Add(i);
                        k = 0;
                    }
            }
            foreach (var item in prosti_brojevi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in prosti_brojevi)
            {
                while (n % item == 0)
                {
                    prosti_faktori.Add(item);
                    n /= item;
                }
            }
            prosti_faktori.Sort();
            Console.Write("Rastav zadanog broja na proste faktore: {0} = ");
            // help i count pomazu pri odredjivanju zadnjeg loopa u foreach tako da izbjegnemo
            //ispisivanje znaka "*" na kraju rastava
            var help = 0;
            var count = prosti_faktori.Count();
            foreach (var item in prosti_faktori)
            {
                Console.Write(item);
                if (++help == count)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");

                }
            }
            Console.ReadLine();
        }
    }
}
