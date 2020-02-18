using System;

namespace _5_2_8_prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0) 
            {
                Console.WriteLine("godina je prijestupna"); }

                else


                {
                    Console.WriteLine("godina nije prijestupna");
                        }
            }
        }
    }

