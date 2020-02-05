using System;

namespace Hello_World
{
    class Program
    {
        /* Blok komentar
         */
         /**
          * doc komentar
          * summary Program za kreiranje automobila
          * */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Automobil A1 = new Automobil();
            A1.MarkaAutomobila = "Pontiac";
            A1.MarkaAutomobila2 = "Lada";
            Console.WriteLine(A1.MarkaAutomobila2);
            Console.WriteLine(A1.MarkaAutomobila);
        }
    }
}
