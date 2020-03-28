using System;

namespace _5_2_4_3_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime skole");
            string skola = Console.ReadLine();

            if (!(skola == "algebra"))
            {
                Console.WriteLine("Mašili ste školu");
            }
            else
            {
                Console.WriteLine("Dobrodošli");
            }

        }
    }
}
