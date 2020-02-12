using System;

namespace _5._2._3_velikibroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj te će vam program reći dali je navedeni broj prevelik \n Dozvoljeni brojevi do 999");
            float br = float.Parse(Console.ReadLine());
            if ( br < 0)
            {
                Console.WriteLine("Broj je manji od 0 te nije valjan");
            }
            else
            {
                if ( br < 1000)
                {
                    Console.WriteLine("Broj je manji od 1000 te je valjan");
                }
                else
                    Console.WriteLine("Broj je veći od 1000 te nije valjan");
            }


        }

        //komentar


    }
}
