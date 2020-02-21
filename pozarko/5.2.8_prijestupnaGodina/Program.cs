using System;

namespace _5._2._8_prijestupnaGodina
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 4 == 0 && x % 100 !=0 || x % 400==0)
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else { Console.WriteLine("Godina nije prijestupna");
            }

        }
    }
}
