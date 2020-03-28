using System;

namespace _8_2_2_1prijenos_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Together we can do so much! And much much more i muchking";
            string a = Console.ReadLine();

            foreach (var item in s)
            {
                if (item.Equals(a))
                {
                    int brojznakova = 0;
                    brojznakova++;
                    Console.WriteLine($"Broj znakova '{a}' u recenici je {brojznakova}");
                }
                
            }
        }
    }
}
