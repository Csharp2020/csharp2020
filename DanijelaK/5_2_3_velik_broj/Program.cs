using System;
/**
 * unesi broj, ako ima više od 3 znamenke ispisi budi velik
 **/
namespace _5_2_3_velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj:");

            string broj= Console.ReadLine();

            broj = broj.Replace("-", "");//-3,14 postaje 3,14
            broj = broj.Replace(",", ""); //3,14 postaje 314
            

            if (broj.Length >= 3)
            {
                Console.WriteLine("Broj je velik");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik");
            }

            int n = 0; //Brojač znamenki
            int br = int.Parse(broj);

            while (br>1)
            {
                br /= 10; //broj=broj /10
                n++;
            }
            if (n >= 3)
            {
                Console.WriteLine("2: Broj je velik");
            }
            else
            {
                Console.WriteLine("2: Broj NIJE velik");
            }

        }
    }
}
