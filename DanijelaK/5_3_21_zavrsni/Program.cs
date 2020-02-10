using System;

namespace _5_3_21_zavrsni
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj predmeta");
            int broj_pred = int.Parse(Console.ReadLine());
            int suma = 0;
            int ulaz = 0;
            for (int i = 0; i < broj_pred; i++)
            {
                Console.WriteLine("Unesi {0}. ocjenu", (i+1));

                try
                {
                    ulaz = int.Parse(Console.ReadLine());
                    if (ulaz > 5 || ulaz <1)
                    {
                        throw new Exception("Ocjena mora biti između 1 i 5");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Neispravan unos! \n");
                    i--;
                    continue;
                }

                if (ulaz <2)
                {
                    suma = 0; 
                    break;
                }
                suma += ulaz;
            }
            if (suma ==0)
            {
                Console.WriteLine("Uspjeh je nedovoljan");
            }
            else
            {
                Console.WriteLine("Prosjek je {0:F2}", (float)suma / broj_pred);
            }
            

        }
    }
}
