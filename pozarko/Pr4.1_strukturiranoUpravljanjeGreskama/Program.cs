using System;

namespace Pr4._1_strukturiranoUpravljanjeGreskama
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos="";
            try
            {
            Console.WriteLine("Unesi broj ili snosi posljedice:");
                unos = Console.ReadLine();
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Broje je {0}", a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Generička greška: \nUnio si {0}\n{1}", unos,ex.Message);
            }
            finally
            {
                Console.WriteLine("Radio ne radio svira ti radio");
            }
        }
    }
}
