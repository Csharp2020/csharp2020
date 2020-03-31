using System;

namespace zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Upisi broj: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Obrnut borj: " + reverse);
        }
    }
}