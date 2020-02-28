using System;
using System.Linq;

namespace _9_1_2_rijec_u_recenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napišite rečenicu");
            string recenica = Console.ReadLine();

            Console.WriteLine("Napišite riječ");
            string rijec = Console.ReadLine();
            int brojac = 0;

            string r = recenica;
            while (r.IndexOf(rijec) != -1)
            {
                brojac++;
                r = r.Substring(r.IndexOf(rijec) + 1);
            }
            Console.WriteLine($"Broj rijeci {rijec} u rečenici je {brojac}.");


            // ovaj primjer traži rijec "je"
            // u recenici ananas je glup jer je ananas
            brojac = 0;
            string[] rastavljena_na_niz_stringova = recenica.Split(" ");
            
            foreach (var item in rastavljena_na_niz_stringova)
            {
                if (item.Equals(rijec))
                {
                    brojac++;
                }
            }
            Console.WriteLine($"Broj rijeci {rijec} u rečenici je {brojac}.");

            // trazimo pomocu replace

            brojac = 0;
            int stanjePrije = recenica.Length;
            recenica = recenica.Replace(rijec, "");

            int stanjePoslije = recenica.Length;
            int duljinaTrazeneRijeci = rijec.Length;

            brojac = (stanjePrije - stanjePoslije) / duljinaTrazeneRijeci;

            Console.WriteLine($"Broj rijeci {rijec} u rečenici je {brojac}.");
        }
    }
}
