using System;
/**
 * traži se unos broja i ispisuje jeli broj 
 * jednozamenkasti,dvoznam., troznam. ili više znam.
 **/
namespace _5_2_4_x_znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
<<<<<<< HEAD
            
            int a;

            a = int.Parse(Console.ReadLine());
            
            if (a < 0)
            {
                a = -a;
            }
=======
            int a;

            a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                a = -a; // mogli smo i ovako a *= -1;
            }

>>>>>>> 806d03656a6a5cfe878e6b8eb153595480cc0cbf

            if (a < 10)
            {
                Console.WriteLine("Broj je jednoznamenkast");
            }
            else if (a < 100)
            {
                Console.WriteLine("Broj je dvoznamenkast");
            }
            else if (a <1000)
            {
                Console.WriteLine("Broj je troznamenkast");
            }
            else
            {
                Console.WriteLine("Broj je višeznamenkast");
            } 

<<<<<<< HEAD
            
                       
=======


>>>>>>> 806d03656a6a5cfe878e6b8eb153595480cc0cbf
            
        }
    }

}