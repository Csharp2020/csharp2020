using System;

namespace uvjetnogrananje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Unešeni broj je veći od 0");
            }


                else if (a < 0)
                {
                    Console.WriteLine("Unešeni broj je manji od 0");
                }
                

                else
                {
                    Console.WriteLine("Unešeni broj je jednak od 0");
                }


 
            }
        }
    }

