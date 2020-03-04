using System;

namespace Prijestupne_godine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijestupne godine su: ");
            for (int i = 1900; i < 2007; i++)
            {

                if (i % 4 == 0 && (i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("Prijestupne godine su {0}", i);
                }

            }
           
        }
    }
}
