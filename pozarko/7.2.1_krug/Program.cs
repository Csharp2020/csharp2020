using System;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Opseg: {0}, Povrsina: {1}",Opseg(r),Povrsina(r));
        }

        private static double Povrsina(float r)
        {
            return r * r * Math.PI;
        }

        private static double Opseg(float r)
        {
            return 2 * r * Math.PI;
        }
    }
}
