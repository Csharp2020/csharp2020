using System;

namespace _8_1_2_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();

            Console.WriteLine("Unesite marku automobila:");
            auto.MarkaAutomobila = Console.ReadLine();
        }
    }
}
