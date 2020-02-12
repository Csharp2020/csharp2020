using System;

namespace _5_3_21_zavrsni
{
    class OcjenaException : Exception
    {
        public OcjenaException()
        {

        }

        public OcjenaException(string name)
            : base(String.Format("broj 1-5", name))
        {

        }
        
        public override string Message
        {
            get
            {
                return "Ocjena mora biti os 1 do 5";
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //todo unesi broj predmeta
            // za svaki predmet unesi ocjenu
            // za sve poz racuna prosjek
            // inace uiospisuje uispjeh je nedovoljan
            // za pogrešno ispisi grešku i ponovi unos

            Console.WriteLine("Unesi broj predmeta");
            int broj_pred = int.Parse(Console.ReadLine());
            int suma = 0;
            int ulaz = 0;
            for (int i = 0; i < broj_pred; i++)
            {
                Console.WriteLine("Unesi {0}. ocjenu:",(i+1));

                try
                {
                    ulaz = int.Parse(Console.ReadLine());
                    if (ulaz > 5 || ulaz < 1)
                    {
                        throw new OcjenaException();
                    }
                }
                catch (OcjenaException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                    continue;
                }
                catch (Exception exx)
                {
                    Console.WriteLine("neispravan unos!\n");
                    i--;
                    continue;
                }
                if (ulaz < 2)
                {
                    suma = 0;
                    break;
                }
                suma += ulaz;
            }
            if (suma==0)
            {
              Console.WriteLine("Uspjeh je nedovoljan!");
            }
            else
            {
                Console.WriteLine("Prosjek ocjena je {0:F2}", (float)suma / broj_pred);
            }
            

        }
    }
}
