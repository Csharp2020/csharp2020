using System;
using System.Collections.Generic;

namespace _8_Vocarna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Banana b1 = new Banana(Duljina: 20);
            Banana b2 = new Banana(10);
            Banana b3 = new Banana(10);
            b3.Trula = true;

            Naranca n1 = new Naranca(Radijus: 10.5);
            Naranca n2 = new Naranca(Radijus: 12.1);

            Apple a1 = new Apple(Tezina: 200);

            // kreirali smo listu svog voća i ubacili sve objekte u nju
            List<Voce> svoVoce = new List<Voce> { b1, b2, b3, n1, n2 };

            // na svako voće smo nakačili event
            svoVoce.ForEach(item => item.PromjenaBoje+=BojaSePromjenila);

            // ispis liste voća
            Console.WriteLine("Ispis liste svog voća: ");
            foreach (var item in svoVoce)
            {
                // event smo mogli nakačiti i u ovoj petlji, primjer kao ovo:
                //item.PromjenaBoje += new Voce.del_promjena_boje(BojaSePromjenila);
                Console.WriteLine("  ---> "+item);
            }

            // pokušamo promjeniti boju kako bi smo vidjeli je li se event digao
            n2.Boja = "Siva";

            // a1.promjenaTezine += A1_promjenaTezine;
            a1.PromjenaTezine += new Apple.del_promjena_tezine(A1_promjenaTezine);
            a1.Tezina = 300;
            a1.Tezina = 200;
            a1.Tezina = 150;



            Banana[] bananas = new Banana[3];
            Banana[] truleBanane = new Banana[2];

            bananas[0] = b1;
            bananas[1] = b2;

            if (b3.Trula)
            {
                truleBanane[0] = b3;
            }
            else
            {
                bananas[2] = b3;
            }

            // ispis zdravih
            Console.WriteLine("Zdrave banane:");
            for (int i = 0; i < bananas.Length; i++)
            {
                Console.WriteLine(bananas[i]);

            }

            // ispis trulih
            Console.WriteLine("Trule banane:");
            for (int i = 0; i < truleBanane.Length; i++)
            {
                if (truleBanane[i] != null)
                {
                    Console.WriteLine(truleBanane[i]);
                }

            }
            /////////////
            ///
            //Lista naranči

            List<Naranca> naras = new List<Naranca>();
            naras.Add(n1);
            naras.Add(n2);
            naras.Add(new Naranca(8.7));

            foreach (var item in naras)
            {
                Console.WriteLine(item);
            }

            // ponovo pokušamo promjeniti boju na drugom mjesu u programu 
            // kako bi smo vidjeli je li se event digao
            b2.Boja = "Crna";

            /////////////////
            ///  Jabuke iz collectionbase

            Apples jabuke = new Apples();
            jabuke.Add(new Apple(212));
            jabuke.Add(a1);
            jabuke.ispis();

            // ispisi sve jabuke:
            foreach (Apple item in jabuke)
            {
                Console.WriteLine($"Jabuka, težina {item.Tezina}g, boja: {item.Boja}");
            }

        }

        private static void BojaSePromjenila(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Boja voća se promjenila: {sender.ToString()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Ova se funkcioja izvrsi kada okine event promjena boje kod jabuke
        private static void A1_promjenaTezine(object sender, EventArgs e)
        {
            Apple.kolikopromjena++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("tezina jabuke je promjenjena! ukupno promjenjeno puta "+ Apple.kolikopromjena);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
