using System;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1");
           // Ispisati svako drugo slovu stringu
            

            string a = "Bio sam u zoloskom vrtu";
            a = a.Replace(" ", "");
            for (int i = 0; i < a.Length; i += 4)
            {
                Console.WriteLine(a.Substring(i, 2));
            }



        }
    }
}
