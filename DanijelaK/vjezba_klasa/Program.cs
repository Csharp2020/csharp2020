using System;

namespace vjezba_klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a1 = new Automobil();
            a1.NaPromjenuGodineProizvodnje += new Automobil.NaPromjenuGodineProizvodnjeDelegat(a1_NaPromjenuGodineProizvodnje);
            Console.WriteLine("Unesi naziv automobila");
            a1.Naziv = Console.ReadLine();
            Console.WriteLine("Unesi godinu proizvodnje");
            a1.GodinaProizvodnja =int.Parse (Console.ReadLine());
            Console.WriteLine("Unesi cijenu");
            a1.OsnovnaCijena = double.Parse (Console.ReadLine());

            Console.WriteLine($"Naziv automobila je: {a1.Naziv}");
           
            Console.WriteLine($"Cijena automobila je: {Math.Round( a1.UkupnaCijena(), 2)}");


        }

        static void a1_NaPromjenuGodineProizvodnje(object sender, EventArgs e)
        {
            Console.WriteLine($"Automobil je star {((Automobil) sender).Starost()} godina");
        }
    }
}
