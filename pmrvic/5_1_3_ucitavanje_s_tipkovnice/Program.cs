using System;

namespace _5_1_3_ucitavanje_s_tipkovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi radijus kruga");
            int a;  // deklaracija

            try
            {
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Unio si radijus "
                    + a
                    + " površina je:"
                    + (a * a * Math.PI)
                    + " opseg je " + (2 * a * Math.PI));
            }
            catch(FormatException fex)
            {
                Console.WriteLine("Nisi unio broj " + fex.Message + " \n " + fex.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Generalna Greška! "+ex.Message +" \n "+ ex.ToString());
            }
        }
    }
}
