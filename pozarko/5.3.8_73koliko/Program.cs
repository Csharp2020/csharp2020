using System;

namespace _5._3._8_73koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    x++;
                }
                else if (i % 3 == 0)
                {
                    y++;
                }
            }
            Console.WriteLine("Dijeljivi sa 7: {0}\nDijeljivi sa 3: {1}", x, y);
        }
    }
}
