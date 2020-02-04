using System;

namespace _5_1_3_ucitavanje_s_tipkovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi radijus kruga");
            int a; //deklaracija

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unio si radijus"+a+" površina je:"+(a*a*3.14)+" opseg je "+(2*a*3,14));
        }
    }
}
