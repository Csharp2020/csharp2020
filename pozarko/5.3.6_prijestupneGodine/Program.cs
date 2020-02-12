using System;

namespace _5._3._6_prijestupneGodine
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1900; i <= 2007; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
