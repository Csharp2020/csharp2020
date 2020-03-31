using System;

namespace _8._3._1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nasljedivanje");
            Brod b1 = new Brod();
            Automobil a1 = new Automobil();
            a1.Naziv = "Mazda";
            a1.Boja = "Zuta";
            a1.KS = 130;
            Console.WriteLine(a1);


            b1.Naziv = "BlackPearl";
            b1.Boja = "Crna";
            b1.KS = 13000;
            b1.Istisnina = 5000; //m3


            // napravi listu automobila za kamion 1
            Automobili k1 = new Automobili();
            k1.Add(a1);
            //k1.Remove(a1);

            foreach(var a in k1)
            {
                Console.WriteLine(a);
            }
        }
    }
}