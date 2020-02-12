using System;

namespace _5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z=1;
            for(int i = 1; i <= x; i++)
            {
                z *= i;
            }
            Console.WriteLine(z);
        }
    }
}
