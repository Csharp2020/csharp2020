using System;

namespace _8_2_doseg_vars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("static klasa - DOSEG varijabli");

            Console.WriteLine("Suma 7.8 + 15.8 je: "+MojStatic.Zbroj(broj1: 7.8, broj2: 15.8));
            Console.WriteLine("Kub 3.0 je: " + MojStatic.Kub(broj1: 3.0));

            Tocka t1 = new Tocka(x:0,y:0);
            Tocka t2 = new Tocka(0,2);
            Tocka t3 = new Tocka(3, 4);
            Tocka t4 = new Tocka(6, 7);

            Crta c1 = new Crta(tocka1: t1, tocka2: t2);
            Console.WriteLine("Duljina crte c1 je:"+c1.Duljina);

            Crta c2 = new Crta(t1,t3);
            Console.WriteLine("Duljina crte c2 je:" + c2.Duljina);

            Console.WriteLine("Duljina crte c3 je:" + (new Crta(t3, t4)).Duljina);


            Console.WriteLine("Udaljenost točaka 0,0 i 0,2 je 2? " + MojStatic.UdaljenostTocaka(tocka1:t1,tocka2:t2));
            Console.WriteLine("Udaljenost točaka 0,0 i 3,4 je 5? " + MojStatic.UdaljenostTocaka(t1,t3));

        }
    }
}
