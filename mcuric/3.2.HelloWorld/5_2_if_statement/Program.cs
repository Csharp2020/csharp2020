using System;

namespace _5_2_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj izmedju 1 i 1,000,000");
            int broj = int.Parse(Console.ReadLine());
            if ((broj % 5 == 0) && (broj % 8 == 0))
            {
                Console.WriteLine("Uneseni broj je djeljiv i sa 5 i sa 8!!");
            }
            else if (broj % 5 == 0)
            {
                Console.WriteLine("Uneseni broj je djeljiv sa 5, ali ne i 8!!");
            }
            else if (broj % 8 == 0)
            {
                Console.WriteLine("Uneseni broj je djeljiv sa 8, ali ne i 5!!");
            }
            else
            {
                Console.WriteLine("Uneseni broj nije djeljiv ni sa 5 ni sa 8!!");
            }
            Console.ReadLine();
        }
    }
}
