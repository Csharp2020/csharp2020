using System;

namespace _5._3._13_minMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetniBr = int.Parse(Console.ReadLine());
            int max = pocetniBr;
            int min = pocetniBr;
            for(int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                }
                else if (x < min)
                {
                    min = x;
                }
            }
            
        }
    }
}
