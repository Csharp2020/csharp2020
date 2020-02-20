using System;

namespace _8._1._3.primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su osobe");
            Osoba o1 = new Osoba();

            Console.WriteLine("Molim unesite ime osobe:");
            o1.Ime = Console.ReadLine();

            Console.WriteLine("Molim unesite prezime osobe:");
            o1.Prezime = Console.ReadLine();

            Console.WriteLine($"Dobrodosli {o1}");
            
        }
    }
}
