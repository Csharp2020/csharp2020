using System;

namespace zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
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
