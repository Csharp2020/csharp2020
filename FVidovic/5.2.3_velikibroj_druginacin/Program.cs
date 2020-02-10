using System;

namespace _5._2._3_velikibroj_druginacin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši broj te će program provjeriti dali je broj unesenih znamenki veći od 3");
            string broj = Console.ReadLine();

            broj = broj.Replace("," , "");
            int br = int.Parse(broj);
            if (br < 0)

            {
                Console.WriteLine("Broj je negativan");
            }
            else if (broj.Length >3)
            Console.WriteLine("Broj je velik");
            else
            {
                Console.WriteLine("Broj nije velik");
            }



            }
        }
    }

