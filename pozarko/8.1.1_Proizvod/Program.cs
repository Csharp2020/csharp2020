using System;

namespace _8._1._1_Proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod();
            Console.WriteLine("Unesite naziv proizvoda:");
            proizvod.Naziv = Console.ReadLine();
            Console.WriteLine("Unesite cijenu proizvoda:");
            proizvod.Cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite marzu proizvoda:");
            proizvod.Marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite porez:");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine(proizvod.MPC());
        }
    }
}
