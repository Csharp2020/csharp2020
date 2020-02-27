using System;

namespace Pr8._1._2_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ucenik u1 = new Ucenik();
            Console.WriteLine("Unesite ime ucenika");

            u1.Ime = Console.ReadLine();
            Console.WriteLine("ucenikovo ime je:" + u1.Ime);

            Console.WriteLine("Unesite prezime ucenika");

            u1.Prezime = Console.ReadLine();

            Console.WriteLine("Unesite ocjenu iz matematike (int)");
            u1.OcjenaIzMatematike = int.Parse(Console.ReadLine());

            u1.Ocjena = Console.ReadLine();
            u1.Ocjena = Console.ReadLine();
            u1.Ocjena = Console.ReadLine();


            /*
            Console.WriteLine("Hello World!");
            MyClass mc1 = new MyClass();
            mc1.zbroj();
            MyClass2 mc2 = new MyClass2("Pero");
            mc2.zbroj("test");
            MyClass3 mc3 = new MyClass3();
            mc3.zbroj("sad");
            */
        }
    }

    class MyClass
    {
        public void zbroj()
        {
            Console.WriteLine("Hello World!, prva");
        }
    }

    class MyClass2
    {
        private string v;
        public MyClass2(string v) //default konstruktor -> ime metode=ime klase, vraca objekt tipa "MyClass2"
        {
            this.v = v;
        }
        //konstruktor = metoda koja se poziva prilikom pozivanja objekta te klase
        public void zbroj(string args)
        {
            Console.WriteLine("Hello World!, treca");
        }
    }

    class MyClass3
    {
        public void zbroj(string args)
        {
            Console.WriteLine("Hello World!, treca");
        }
    }
}
