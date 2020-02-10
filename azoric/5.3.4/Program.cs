using System;

namespace _5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite broj");
            int x;
            x =  int.Parse (Console.ReadLine());
            int rezultat = 1;
            
            for (int i =1; i <=x; i++ )
            {
                rezultat = rezultat * i;
            }
            Console.WriteLine(rezultat);
        }
    }
}
