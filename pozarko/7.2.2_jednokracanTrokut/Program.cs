using System;

namespace _7._2._2_jednokracanTrokut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Povrsina iznosi {0}", Povrsina(x));
        }

        private static float Povrsina(int x)
        {
            return (x * x) / 2;
        }
    }
}
