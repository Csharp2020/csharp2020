using System;

namespace _8_1_1_proizvodđ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu, marzu i porez proizvoda");

            Proizvod proizvod = new Proizvod(Console.ReadLine());

            Console.Write("Unesite naziv proizvoda: ");
            proizvod.Naziv = Console.ReadLine();
            
            Console.Write("Unesite cijenu proizvoda: ");
            proizvod.Cijena = double.Parse(Console.ReadLine());
           
            Console.Write("Unesite marzu proizvoda: ");
            proizvod.Marza = double.Parse(Console.ReadLine());
            
            Console.Write("Unesite porez proizvoda: ");
            proizvod.Porez = double.Parse(Console.ReadLine());


            Console.Write("Maloprodajna cijena proizvoda je: {0} ", proizvod.MPC());
            Console.ReadKey();
        }
    }
}
