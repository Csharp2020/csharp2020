using System;

namespace _5._2._5_uIntervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if ((i >= 100) && (i <= 200))
            {
                Console.WriteLine("Broj je u intervalu [100,200]");
            }
            else
            {
                Console.WriteLine("Broj NIJE u intervalu [100,200]");
            }
        }
    }
}
