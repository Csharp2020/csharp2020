using System;

namespace _5_3_savrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savrseni brojevi unutar prvih 10 000 brojeva su: ");
            for (int i=1; i <= 10000; i++)
            {
                int zbroj = 0;
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        zbroj += j;
                    }
                }
                if (zbroj == i) Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
