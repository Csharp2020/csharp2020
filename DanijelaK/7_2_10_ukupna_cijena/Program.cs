using System;

namespace _7_2_10_ukupna_cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ulaznu cijenu:");
            double ulaz = double.Parse(Console.ReadLine());

            Console.WriteLine("Ukupna cijena je {0}.", UkupnaCijena(ulaz));
        }

        private static double Marza(double ulaz)
        {
            double marza = 0;

            if (ulaz < 100)
            {
                marza = 5.5;
            }
            else if (ulaz < 250)
            {
                marza = 9.5;
            }
            else if (ulaz < 500)
            {
                marza = 15;
            }
            else if (ulaz < 1000)
            {
                marza = 25;
            }
            else 
            {
                marza = 50;
            }
            return marza;
        }

        private static double Porez(double ulaz)
        {
            double porez = 0;

            if (ulaz < 100)
            {
                porez = 0.02 * ulaz;
            }
            else if (ulaz < 250)
            {
                porez = 0.03 * ulaz;
            }
            else if (ulaz < 500)
            {
                porez = 0.04 * ulaz;
            }
            else if (ulaz < 1000)
            {
                porez = 0.05 * ulaz;
            }
            else
            {
                porez = 0.1 * ulaz;
            }
            return porez;
        }

        private static double UkupnaCijena(double ulaz)
        {
            return ulaz + Marza(ulaz) + Porez(ulaz) + ulaz * 0.25;
        }
    }
}
