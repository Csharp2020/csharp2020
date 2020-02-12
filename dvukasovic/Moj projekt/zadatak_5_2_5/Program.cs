using System;

namespace zadatak_5_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesibroj");
            double a = double.Parse(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                Console.WriteLine("Broj je intervalu od 100 do 200");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
