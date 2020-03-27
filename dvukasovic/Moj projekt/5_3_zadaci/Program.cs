using System;

namespace _5_3_zadaci
{
    class Program
    {
        static void Main(string[] args)
        { //5.3.1.
            Console.WriteLine("Zadatak 5.3.1");
            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Zadatak 5.3.2");
            // 5.3.2
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Zadatak 5.3.4");
            Console.WriteLine("");
            Console.WriteLine("Unesi jedan broj");
            int broj = int.Parse(Console.ReadLine());
            int fakt = 1;
            for (int i = 1; i < broj; i++)
            {
                fakt *= i;
            }
            Console.WriteLine("Faktorijel od " + broj + " je= " + fakt);

            Console.WriteLine("Zadatak 5.3.5");
            Console.WriteLine("Brojevi dijeljivi sa 3");
            for (int i = 0; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Prijestupne godine
            Console.WriteLine("Zadatak 5.3.6");
            Console.WriteLine("");
            for (int i = 1900; i < 2007; i++)
            {
                if ((i % 4==0 && (!(i%100== 0))) || (i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}
