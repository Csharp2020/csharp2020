using System;
using System.Collections.Generic;

namespace Zadatak_Voce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voće");

            Banana b1 = new Banana(10);
            Banana b2 = new Banana(15);
            b1.Duljina = 10;
            b2.Duljina = 15;


            Naranca n1 = new Naranca(10);
            Naranca n2 = new Naranca(8);
            n1.Radijus = 10;
            n2.Radijus = 8;

            Apple a1 = new Apple();
            Apple a2 = new Apple();
            a1.Kila = 0,2;
            a2.Kila = 0,3;

            Banana[] bananas = new Banana[2];
            bananas[0] = b1;
            bananas[1] = b2;
            for (int i = 0; i < bananas.Length; i++)
            {
                Console.WriteLine();
            }

            List<int> arr = new List<int>();




        }
    }
}
