using System;

namespace _8_1_2_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            automobil automobil = new automobil();

            Console.Write("Unesite marku automobila: ");
            automobil.MarkaAutomobila = Console.ReadLine();
            Console.Write("Unesite broj konjskih snaga: ");
            automobil.KS = double.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.Write("Iznos poreza: {0} \nUkupna cijena: {1}", automobil.IznosPoreza(),
                automobil.UkupnaCijena());
            Console.ReadKey();

        }
    }
}
