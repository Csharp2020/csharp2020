using System;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1");
           // Ispisati svako drugo slovu stringu
            string recenica = "Bio sam u zološkom vrtu";
            
            Console.WriteLine(recenica.Replace(" ", ""));
            for (int i = 0; i < recenica.Length; i+=1)
            {

                Console.WriteLine(recenica[i].ToString());
            }
            

           

        }
    }
}
