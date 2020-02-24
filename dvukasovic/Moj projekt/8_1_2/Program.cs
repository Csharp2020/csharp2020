using System;

namespace _8_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automobil");
            Automobil automobil = new Automobil();

            Console.WriteLine("Unesi marku automobila:");
            automobil.MarkaAutomobila = Console.ReadLine();

            Console.WriteLine("Unesi broj konjski snaga:");
            automobil.KS = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi osnovnu cijenu:");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Iznos poreza: {0}\nUkupnaCijena: {1}", automobil.IznosPoreza(), automobil.UkupnaCijena());




        }
    }
}
