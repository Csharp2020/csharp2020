using System;

namespace _7_2_3_KSuKW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zelite li pretvoriti KS u KW pritisnite 1, ukoliko zelite KW u KS pritisnite 2!");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Unesite KS: ");
                double KS = double.Parse(Console.ReadLine());
                Console.WriteLine("{0} KS = {1} KW", KS, KSuKW(KS));
            }
            else if (a == 2)
            {
                Console.WriteLine("Unesite KW: ");
                double KW = double.Parse(Console.ReadLine());
                Console.WriteLine("{0} KW = {1} KS", KW, KWuKS(KW));
            }
            else
                Console.WriteLine("Unesena je pogresna vrijednost, molimo Vas da napustite program i probate ponovo!");

            Console.ReadLine();
        }

        static double KSuKW(double ks)
        {
            return 0.736 * ks;
        }

        static double KWuKS(double kw)
        {
            return kw/0.736;
        }
    }
}
