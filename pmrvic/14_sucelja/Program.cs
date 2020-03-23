using System;

namespace _14_sucelja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pas p1 = new Pas();
            if (p1.JelSpava())
            {
                p1.budise();
            }
            Console.WriteLine(p1);
            p1.trci();

            Buldog b1 = new Buldog();
            Console.WriteLine(b1);

        }
    }
}
