using System;

namespace _5._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x;
            x = int.Parse(Console.ReadLine());
            int rezulat = 1;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);

                }
                    
            }
                
            
        }
    }
}
