using System;

namespace _9_1_2_rijec_u_recenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 1 2 rijec u rijecui, unesi rijec i jedan znak iz rijeci");

            string recenica = Console.ReadLine();
            string rijec = Console.ReadLine();
            int brojznakova = 0;

            //Substring(int startIndex);
            //int IndexOf(String value);

            ////// prvi nacin, rezanjem stringa
            string r = recenica;
            while (r.IndexOf(rijec) != -1)
            {
                brojznakova++;
                r = r.Substring(r.IndexOf(rijec) + 1);
            }
            Console.WriteLine($"Broj znakova '{rijec}' u recenici je {brojznakova}");

            // ovaj primjer trazi rijec "je"
            // u recenici "ananas je glup jer je ananas"
            brojznakova = 0;
            string[] rastavljana_na_niz_stringova=recenica.Split(" ");
            foreach (var item in rastavljana_na_niz_stringova)
            {
                if (item.Equals(rijec)) {
                    brojznakova++;
                } 
            }
            Console.WriteLine($"Broj znakova '{rijec}' u recenici je {brojznakova}");

            // u recenici "ananas je glup jer je ananas"
            // trazimo pomocu replace

            brojznakova = 0;
            int stanjePrije = recenica.Length;
            recenica = recenica.Replace(rijec, "");

            int stanjePoslije = recenica.Length;
            int duljinaTrazeneRijeci = rijec.Length;
            brojznakova = (stanjePrije- stanjePoslije) / duljinaTrazeneRijeci;

            Console.WriteLine($"Broj znakova '{rijec}' u recenici je {brojznakova}");


        }
    }
}
