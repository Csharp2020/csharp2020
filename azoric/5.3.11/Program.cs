using System;

namespace _5._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj!");

            // int a = int.Parse(Console.ReadLine());
            for (int a = 1; a < 1000; a++)
            {


                int broj = 0;

                for (int i = 1; i < a; i++)
                {

                    if (a % i == 0)
                    {
                        broj += i; //broj=brojevi+i
                    }

                }
                if (a == broj)
                {
                    Console.WriteLine("{0} ", a);
                }
                else
                {
                    // Console.WriteLine("Uneseni broj nije savrsen.");
                }

            }







        }
    }
}

