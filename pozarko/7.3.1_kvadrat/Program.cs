using System;

namespace _7._3._1_kvadrat
{
    class Program
    {
        /*U ovom programu koristimo metode od kojih ocekujemo povratnu vrijednost koja je tipa int*/
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadriramo broj");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Broj {0} je na kvadrat jednak {1}", broj, Kvadrat(broj));
            Console.WriteLine("Broj {0} je na kub jednak {1}", broj, Kub(broj));
            Console.WriteLine("Broj {0} je na 4. exp je jednak {1}", broj, NeCetvrtu(broj));
        }

        private static int NeCetvrtu(int broj)
        {
            //-return Kub(broj) * broj;
            //-return Kvadrat(broj) * Kvadrat(broj); 
            //-return broj * broj * broj * broj;
            //-return Kvadrat(Kvadrat(broj));
            return (int)Math.Pow(broj, 4);//-Zato što math.poew vraca double
        }

        private static int Kub(int broj)
        {
            return Kvadrat(broj) * broj;
        }

        private static int Kvadrat(int broj)
        {
            return broj + broj;
        }
    }
}
