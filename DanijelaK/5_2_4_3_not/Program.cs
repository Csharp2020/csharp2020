using System;

namespace _5_2_4_3_not
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("unesi ime skole");
            string skola = Console.ReadLine();


            if (!(skola == "algebra")) // !(true) = (false)
            {
                Console.WriteLine("Mašili ste školu!");
            }
            else
            {
                Console.WriteLine("Dobrodošli");
                
            }
        }
    }
}
