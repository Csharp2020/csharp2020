using System;

namespace _8_1_3_Osoba
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

            Console.WriteLine($"Dobrodošli {o1}");

            Console.WriteLine("Molim unesite datum rođenja:");

            o1.Datrod = Console.ReadLine();
            o1.IspisBrojGodina();



        }
    }
}
