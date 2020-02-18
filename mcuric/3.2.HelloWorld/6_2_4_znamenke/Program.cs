using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_2_4_znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            //program trazi unos prirodnog broja, a zatim znamenke unesenog broja ispisuje naopako
            Console.WriteLine("Unesite prirodan broj n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> znamenke = new List<int>();
            while (n > 0) 
            {
                znamenke.Add(n % 10);
                n /= 10;
            }
            foreach (var item in znamenke)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
