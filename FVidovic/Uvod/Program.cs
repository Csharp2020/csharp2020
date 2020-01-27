using System;

namespace Uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Automobil A1 = new Automobil();
            A1.MarkaAutomobila = "Pontiac";
            Console.WriteLine(A1.MarkaAutomobila);

        }
    }
}
