using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proizvod");
            Console.WriteLine("Unesi naziv proizvoda!");
            Proizvod proizvod = new Proizvod(Console.ReadLine());
            
            

            Console.WriteLine("Unesi cijenu proizvoda!");
            proizvod.Cijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi marzu proizvoda!");
            proizvod.Marza = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi porez proizvoda!");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("MPC za proizvod " + proizvod.Naziv +  " a mpc je " + proizvod.MPC());
        }
    }
}
