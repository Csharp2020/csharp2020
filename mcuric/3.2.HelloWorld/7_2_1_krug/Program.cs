using System;

namespace _7_2_1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            //trazi unos radijusa te zatim ispisuje opseg i povrsinu kruga
            //koristiti dvije odvojene funkcije

            Console.WriteLine("Unesite radijus kruznice!");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Opseg zadane kruznice iznosi {0}", Opseg(r));
            Console.WriteLine("Povrsina zadane kruznice iznosi {0}", Povrsina(r));
            Console.ReadLine();
        }

        static double Opseg(double x)
        {
            return 2 * x* Math.PI;
        }

        static double Povrsina(double x)
        {
            return x * x * Math.PI;
        }
    }
}
