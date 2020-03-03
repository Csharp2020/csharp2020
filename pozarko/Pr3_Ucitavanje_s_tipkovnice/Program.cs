using System;

namespace Pr3_Ucitavanje_s_tipkovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi radijus kruga");
            int a; //deklaracija

            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unio si radijus" + a + " površina je: " + (a * a * Math.PI) + " opseg je " + (2 * a * Math.PI));
            }

            catch(FormatException fex)
            {
                Console.WriteLine("Nisi unio broj\n" + fex.Message + "\n\n" + fex.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Krivi unos"+ex.Message +"\n"+ ex.ToString());
            }

        }
    }
}
