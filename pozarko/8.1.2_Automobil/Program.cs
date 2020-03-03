using System;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();
            Console.WriteLine("Marka automobila:");
            auto.MarkaAutomobila = Console.ReadLine();
            Console.WriteLine("KS:");
            auto.KS = double.Parse(Console.ReadLine());
            Console.WriteLine("Osnovna cijena:");
            auto.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Cijena {0} iznosi:", auto.MarkaAutomobila);
            Console.WriteLine(auto.UkCijena());
        }
    }
}
