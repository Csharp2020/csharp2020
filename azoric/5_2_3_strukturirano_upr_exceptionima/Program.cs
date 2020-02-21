using System;

namespace _5_2_3_strukturirano_upr_exceptionima
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos = "";

            try
            {
                Console.WriteLine("Unesi broj ili snosi posljedice: !");
                
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Broj je {0}", a);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Genericka greska \n unio si {0} \n{1}",unos,  ex.Message);
            }
            
            finally
            {
                Console.WriteLine("radio ne radio svira ti radio");
            }
        }
    }
}
