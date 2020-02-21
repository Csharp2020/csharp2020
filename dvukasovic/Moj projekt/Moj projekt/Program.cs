using System;

namespace Moj_projekt
{
    class Program
    {
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
