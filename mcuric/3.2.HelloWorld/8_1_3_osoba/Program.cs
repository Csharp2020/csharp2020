using System;

namespace _8_1_3_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su osobe: ");
            Osoba o1 = new Osoba();
            Console.WriteLine("Molim unesite ime osobe: ");
            o1.Ime = Console.ReadLine();
            Console.WriteLine("Molim unesite prezime osobe: ");
            o1.Prezime = Console.ReadLine();
            Console.WriteLine($"Dobrodosli {o1}");
            Console.WriteLine("Molim, unesite datum rodjenja u sljedecem formatu MM/DD/YYYY");
            o1.Dob = DateTime.Parse(Console.ReadLine());
            o1.ShowAge();

            Console.ReadLine();
        }
    }
}
