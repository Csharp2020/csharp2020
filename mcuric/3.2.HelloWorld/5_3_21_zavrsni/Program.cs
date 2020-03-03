using System;

namespace _5_3_21_zavrsni
{
    class Program
    {

        class OcjenaException : Exception
        {
            public OcjenaException()
            {

            }

            public OcjenaException(string message)
                : base(String.Format("Ocjena ne moze biti tolika. Mora biti izmedju 1 i 5!"))
            {

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj predmeta");
            int brojPred = int.Parse(Console.ReadLine());
            int suma = 0;
            int ulaz;
            for(int i = 0; i < brojPred; i++)
            {
                Console.WriteLine("Unesite {0}. ocjenu", i+1);
                try
                {
                    ulaz = int.Parse(Console.ReadLine());
                    if (ulaz < 1 || ulaz > 5) throw new OcjenaException("Ocjena ne moze biti tolika. Mora biti izmedju 1 i 5!");
                }
                catch (OcjenaException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    continue;
                }
                if (ulaz < 2)
                {
                    suma = 0;
                    break;
                }
                else
                {
                    suma += ulaz;
                }
            }
            if (suma == 0)
            {
                Console.WriteLine("Uspjeh je nedovoljan!");
            }
            else
            {
                float prosjek = (float)suma / brojPred;
                Console.WriteLine("Prosjek je {0:F2}. Cestitamo!!", prosjek);
            }
            Console.ReadKey();

        }
    }
}
