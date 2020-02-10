using System;

namespace ReadLineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi radijus kruga");
            int a; //deklaracija//


            try
            {

                a = int.Parse(Console.ReadLine());



                Console.WriteLine("Unio si radijus " +
                    a +
                    "," +
                    "površina je " +
                    (a * a * Math.PI) +
                    " a opseg je " +
                    (2 * a * Math.PI));
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Nisi unio broj! " + fex.Message + " \n " + fex.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Generalna Greška! " + ex.Message + " \n " + ex.ToString());
            }
            
            //Unio si radijus10,površina je314,159265358979a opseg je62,8318530717959

        }
    }
}
