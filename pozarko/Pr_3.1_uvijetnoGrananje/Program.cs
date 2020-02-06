using System;

namespace Pr_3._1_uvijetnoGrananje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsite prirodan broj");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Unjeli ste prirodan broj");
            }

            else
            {
                Console.WriteLine("Uneseni broj nije prirodan broj");
            }
        }
    }
}
