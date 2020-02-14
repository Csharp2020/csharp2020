using System;

namespace uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            automobil A1 = new automobil();
            A1.MarkaAutomobila = "Pontiac";
            A1.MarkaAutomobila = "Lada";
            Console.WriteLine(A1.MarkaAutomobila2);
            Console.WriteLine(A1.MarkaAutomobila);
                
        }
    }
}
