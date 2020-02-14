using System;

namespace _5_2_4_3_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime skole");
            string skola = Console.ReadLine();
            Console.WriteLine("Unesi password");


            if (!(skola == "algebra")) // (true) = (true) 

            {
                Console.WriteLine("Masili ste skolu");
            }
            else
            {
                Console.WriteLine("Dobrodosli");
            }
        }
    }
}
