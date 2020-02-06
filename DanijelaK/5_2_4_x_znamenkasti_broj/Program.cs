using System;
/**
 * traži se unos broja i ispisuje jeli broj jednozamenkasti,dvoznam., troznam. ili više znam.
 **/
namespace _5_2_4_x_znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            /* double a = double.Parse(Console.ReadLine());

            if (a < 0) a = -a;

            if (a < 10)
            {
                Console.WriteLine("Broj je jednoznamenkast");
            }
            else if (a < 100)
            {
                Console.WriteLine("Broj je dvoznamenkast");
            }
            else if (a <1000)
            {
                Console.WriteLine("Broj je troznamenkast");
            }
            else
            {
                Console.WriteLine("Broj je višeznamenkast");
            } */

            int a;
            
            a = int.Parse(Console.ReadLine());
            a = -a;
                       
            switch (a)
            {
                case int i when i < 10:
                    Console.WriteLine("Broj je jednoznamenkast");
                    break;
                case int i when i < 100:
                    Console.WriteLine("Broj je dvoznamenkast");
                    break;
                case int i when i < 1000:
                    Console.WriteLine("Broj je troznamenkast");
                    break;
                default:
                    Console.WriteLine("Broj je višeznamenkast");
                    break;

            }
        }
    }

}