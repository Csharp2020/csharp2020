using System;

namespace _8_1_1_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naziv proizvoda:");
            Proizvod p = new Proizvod();

            Console.WriteLine("Unesite cijenu proizvoda:");
            p.Cijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite maržu proizvoda:");
            p.Marza = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite Porez proizvoda:");
            p.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena {0} je {1}.", p.Naziv, p.MPC()); 
        }

    }
}
