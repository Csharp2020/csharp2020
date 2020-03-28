using System;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Unesi Naziv automobila");
            Automobil a1 = new Automobil();
            a1.Naziv = Console.ReadLine();
            Console.WriteLine("Unesi godinu proizvodnje automobila");
            a1.GodinaProizvodnje = int.Parse(Console.ReadLine());
            Console.WriteLine("Osnovnu Cijenu Automobila");
            a1.OsnovnaCijena = int.Parse(Console.ReadLine());

            Console.WriteLine(a1);
            Console.WriteLine("Ukupna cijena je {0}", a1.UkupnaCijena());
        }
    }
}
