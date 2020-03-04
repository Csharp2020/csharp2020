using System;

namespace Neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni do 20!");
            for (int i = 2; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("To su parni " + i);
                }
                else
                {
                    Console.WriteLine("Neparni brojevi od 2 do 20 su: " + i);
                }


            }
        }
    }
}
