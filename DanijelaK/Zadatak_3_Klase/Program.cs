using System;

namespace Zadatak_3_Klase
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            Console.WriteLine("Unesite ime:");
            u1.Ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime:");
            u1.Prezime =(Console.ReadLine());
            Console.WriteLine("Unesite datum rođenja:");
            u1.DatumRodjenja = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Unesite prosjek ocjena:");
            u1.Prosjek = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ime i prezime ucenika je: {u1.Ime} {u1.Prezime}" );
            Console.WriteLine($"Datum rođenja učenika je: {u1.DatumRodjenja: dd / MM / yyyy} ");
            Console.WriteLine($"Učenik ima { u1.Starost()} godina");
            Console.WriteLine($"Prosjek ocjene je: {u1.ProsjekRijecima()}");

            Console.WriteLine(u1);



        }
    }
}
