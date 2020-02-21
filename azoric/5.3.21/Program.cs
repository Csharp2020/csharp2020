using System;

namespace _5._3._21
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
                Console.WriteLine("Unesi {0}. ocijenu:", (i + 1));

                ulaz = int.Parse(Console.ReadLine());
                if (ulaz < 2)
                {
                    suma = 0;

                    break;

                }

            }
            if (suma == 0)
            {
                Console.WriteLine("Unesi broj predmeta");
            }
            else
            {
                Console.WriteLine("Prosjek ocjena je {0}", (suma / broj_pred));

            }
            
        }
        // todo unesi broj predmeta
        // za svaki predmet unesi ocjenu
        // za sve pozitivne racuna prosjek
        // inace ispisuje uspjeh je nedovoljan
        // za progresku ispisi gresku i ponovi unos

        



    }
}
