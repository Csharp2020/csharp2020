using System;

namespace _5._2._4_xZnamenkastiBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if (((i >= 0) && (i < 10)) || ((i <= 0) && (i > -10))){
                Console.WriteLine("Broj je jednoznamenkast");
            }
            else if (((i >= 10) && (i < 100)) || ((i <= -10) && (i > -100)))
            {
                Console.WriteLine("Broj je dvoznamenkast");
            }
            else if (((i >= 100) && (i < 1000)) || ((i <= -100) && (i > -1000)))
            {
                Console.WriteLine("Broj je troznamenkast");
            }
            else
            {
                Console.WriteLine("Broj je viseznamenkast");
            }
        }
    }
}
