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
                Console.WriteLine("Upisi broj ili snosi posljedice");
                unos = Console.ReadLine();
                int a = int.Parse(unos);
                Console.WriteLine("Broj je {0}", a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generička greška: \n unosio si {0} \n {1}", unos, ex.Message);
                
            }
            finally
            {
                Console.WriteLine("Radio ne radio svira ti radio");
            }


        }
    }
}
