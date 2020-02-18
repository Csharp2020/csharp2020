using System;

namespace _7_2_10_ukupna_cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ulaznu cijenu proizvoda u dolarima!");
            double ulazna = double.Parse(Console.ReadLine());

            Console.WriteLine("Ukupna cijena danog proizvoda bi bila {0:C} ", KonacnaCijena(ulazna));

            Console.ReadLine();
        }

        static double KonacnaCijena(double x)
        {
            double marza = 0;
            double porez = 0;
            double pdv = 0.25;

            if (x < 100)
            {
                marza = 5.5;
                porez = 0.02 * x; 
            }
            else if (x>=100 && x < 250)
            {
                marza = 9.5;
                porez = 0.03 * x;
            }
            else if (x >= 250 && x < 500)
            {
                marza = 15;
                porez = 0.04 * x;
            }
            else if (x >= 500 && x <= 1000)
            {
                marza = 25;
                porez = 0.05 * x;
            }
            else if (x > 1000)
            {
                marza = 50;
                porez = 0.1 * x;
            }
            else
            {
                Console.WriteLine("Cijena nije pravilno unesena!");
            }

            return x + marza + porez + (x + marza + porez) * pdv;
        }
    }
}
