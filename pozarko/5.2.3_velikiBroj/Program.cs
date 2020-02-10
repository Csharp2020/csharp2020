using System;

namespace _5._2._3_velikiBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            string broj=Console.ReadLine();
            broj = broj.Replace(",", "");
            if(broj.Length>=3)
            {
                Console.WriteLine("Broj je vilik");
            }
            else
            {
                Console.WriteLine("Broj nije vilik");
            }

            int n = 0;
            int br = int.Parse(broj);

            while (br > 0)
            {
                br /= 10;
                n++;
            }
            if (n >= 3)
            {
                Console.WriteLine("Broj je vilik");
            }
            else
            {
                Console.WriteLine("Broj nije vilik");
            }
            /*
            int i = int.Parse(Console.ReadLine());
            if (i > 99)
            {
                Console.WriteLine("Broj je velik");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik");
            }
            */
        }
    }
}
