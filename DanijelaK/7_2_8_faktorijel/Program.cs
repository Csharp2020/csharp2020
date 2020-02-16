using System;

namespace _7_2_8_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ocjenu:");
            double ocjena = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Uspjeh je {0}", Prosjek(ocjena));
            
        }
        private static string Prosjek(double ocjena)
        {
            string prosj = "";

            if (ocjena<2)
            {
               prosj="nedovoljan"; 
            }
            else if (ocjena < 2.5)
            {
                prosj = "dovoljan";
            }
            else if (ocjena < 3.5)
            {
                prosj = "dobar";
            }
            else if (ocjena < 4.5)
            {
                prosj = "vrlo dobar";
            }
            else
            {
                prosj = "odličan";
            }
            return prosj;
        }
    }
    
}
