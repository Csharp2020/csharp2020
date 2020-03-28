using System;

namespace _8_3_1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naslijeđivanje");
            
            Automobil a1 = new Automobil();
            a1.Naziv = "Mazda";
            a1.Boja = "Zua";
            a1.KS = 130;
            Console.WriteLine(a1);

            Brod b1 = new Brod();
            b1.Naziv = "SunSeeker";
            b1.Boja = "Zlatna";
            b1.KS = 13000;
            b1.Istisnina = 3;

            // napravi listu automobila za kamion 1
            Automobili k1 = new Automobili();
            k1.Add(a1);
            k1.Add(a1);
            k1.Add(a1);
            k1.Add(a1);
            k1.Add(a1);
            k1.Remove(a1);

            //ispis kamiona a1
            foreach(Automobil a in k1)
            {
                Console.WriteLine(a);
            }

        }
    }
}
