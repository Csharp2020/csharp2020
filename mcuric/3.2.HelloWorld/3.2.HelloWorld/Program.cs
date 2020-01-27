using System;

namespace _3._2.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Automobil A1 = new Automobil();
            A1.MarkaAutomobila = "Chrysler";
            Console.WriteLine(A1.MarkaAutomobila2);
            Console.ReadKey();

        }
    }
}
