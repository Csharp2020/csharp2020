using System;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Opseg: {0}, Povrsina: {1}",Opseg(r),Povrsina(r));
        }

        //Prima int, vraca double(jer je PI tipa double), da nije mozemo joj staviti tip float jer ne ocekujemo cijelobrojni broj.
        private static double Povrsina(int r)
        {
            return r * r * Math.PI;
        }

        private static double Opseg(int r)
        {
            return 2 * r * Math.PI;
        }
    }
}
