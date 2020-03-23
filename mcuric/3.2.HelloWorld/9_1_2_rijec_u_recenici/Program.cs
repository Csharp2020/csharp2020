using System;

namespace _9_1_2_rijec_u_recenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu!");
            string recenica = Console.ReadLine();
            Console.WriteLine("Unesite rijec koju zelite naci! ");
            string rijec = Console.ReadLine();

            int brojac = 0;

            string[] rastavljena_na_niz_stringova = recenica.Split(" ");
            foreach (var item in rastavljena_na_niz_stringova)
            {
                if (item.Equals(rijec))
                {
                    brojac++;
                }
            }

            Console.WriteLine("Broj ponavljanja rijeci u danoj recenici je: {0}", brojac);

            int kolikoputa = 0;
            while (recenica.IndexOf(rijec) != -1)
            {
                recenica = recenica.Substring(recenica.IndexOf(rijec) + rijec.Length);
                kolikoputa++;
            }

            Console.WriteLine(kolikoputa);

            Console.ReadLine();
        }
    }
}
