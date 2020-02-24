using System;

namespace _8_3_1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nasljeđivanje");
 
            Automobil a1 = new Automobil();
            a1.Naziv = "Mazda";
            a1.Boja = "Zuta";
            a1.KS = 130;
            Console.WriteLine(a1);

            Brod b1 = new Brod();
            b1.Naziv = "SunSeeker";
            b1.Boja = "Zlatna";
            b1.KS = 13000;
            b1.Istisnina = 3; //m3

            // napravi listu automobila za kamion 1
            Automobili k1 = new Automobili();

            Automobil a2 = new Automobil(Naziv:"Opel",Boja:"Crni",KS:55);
            Automobil a3 = new Automobil("Merc", "Bijeli", 80);
            Automobil a4 = new Automobil("Golf", "Crveni", 45);

            k1.Add(a1);
            k1.Add(a2);
            k1.Add(a3);
            k1.Add(a4);
            k1.Add(a1);
            //k1.Add(b1);  ne može brod u listu automobila
            //k1.Remove(a1);

            // ispis kamiona k1
            foreach (var a in k1)
            {
                Console.WriteLine(a);
            }



        }
    }
}
