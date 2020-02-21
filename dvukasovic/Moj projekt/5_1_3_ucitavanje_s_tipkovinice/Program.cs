using System;

namespace _5_1_3_ucitavanje_s_tipkovinice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi jedan broj ");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unio si " + a + " površina je:" + (a * a * Math.PI) + " a opseg je " + (2 * a * Math.PI));
        }
    }
}
