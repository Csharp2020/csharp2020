using System;
using System.Collections;
using System.Collections.Generic;

namespace _8_3_1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList vozila = new ArrayList();
            Automobili automobili = new Automobili();

            Console.WriteLine("Zelite li unijeti vozilo? Y/N");
            Boolean unos = true;
            string odgovor = Console.ReadLine();
            if (odgovor == "y")
            {
                unos = true;
            }
            else
            {
                unos = false;
            }
            if (unos)
            {
                Console.WriteLine("Zelite li unijeti automobil ili brod? A/B");
                odgovor
            }
        }
    }
}
