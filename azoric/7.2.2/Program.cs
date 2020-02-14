using System;

namespace _7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispisuje ime i pozdrav");
            Pozdrav("Pero");
            Pozdrav("Pero","Perić");
            
        }

        private static void Pozdrav(string v1, string v2)
        {
            Console.WriteLine(" Pozdrav {0} {1}!", v1, v2);
        }

        private static void Pozdrav(string v)
        {
            Console.WriteLine(" Pozdrav {0}!", v);
        }
    }
}
