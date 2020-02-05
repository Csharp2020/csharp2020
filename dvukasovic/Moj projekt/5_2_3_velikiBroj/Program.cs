using System;

namespace _5_2_3_velikiBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Unesi broj");
            int broj= int.Parse(Console.ReadLine);
            switch (broj)
            {
                case broj => 100:
                Console.WriteLine("Broj je u intervalu od 100 do 200);
                break;
                
                case broj <= 200:
                Console.WriteLine("Broj je u intervalu od 100 do 200);
                break;
                
                case broj < 100:
                Console.WriteLine("Broj nije u intervalu od 100 do 200);
                break;
                
                case broj > 200:
                Console.WriteLine("Broj nije u intervalu od 100 do 200);
                break;
            }
            */
            Console.WriteLine("Unesibroj");
            int a = int.Parse(Console.ReadLine);
            if (a >= 100 && a<=200)
            {
                Console.WriteLine("Broj je u intervalu od 100 do 200");
            }
            else
            {
                Console.WriteLine("Broj nije u intervalu u 100 do 200");
            }
        }
    }
}
