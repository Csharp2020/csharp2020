using System;

namespace zadatak
{
    class Program
    {
        static void Main(string[] args)
        {

            // Napišite program koji traži unos prirodnog broja, a zatim:
            //1.ispisuje taj broj "naopako"  1 bod
            //(Na primjer, za unešeni broj 1234 treba se ispisati 4321)

            Console.WriteLine("Unesite broj");
            string broj = Console.ReadLine();
            string broj_naopako = "";

            for (int i = broj.Length-1; i >= 0; i--)
            {
                broj_naopako += broj[i];
            }

            Console.WriteLine("Beoj naopako je {0}", broj_naopako);


            Console.WriteLine("Unesite broj");
            int broj1 = int.Parse(Console.ReadLine());

            while (broj1 > 0)
            {
                Console.Write(broj1 % 10);
                broj1= (int) (broj1/10);
            }


        }
    }
}
