using System;

namespace _7_3_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kavadriramo broj");

            int beroj = int.Parse(Console.ReadLine());

            Console.WriteLine("broj {0} je na kvadrat jednak {1}", beroj, Kvadrat(beroj));

            Console.WriteLine("broj {0} je na kub jednak {1}", beroj, Kub(beroj));

            Console.WriteLine("broj {0} je na 4. exponent jednak {1}", beroj, NaCetvrtu(beroj));
        }

        private static int NaCetvrtu(int beroj)
        {
            //return Kub(beroj) * beroj;
            //return Kvadrat(beroj) * Kvadrat(beroj);
            //return beroj * beroj * beroj * beroj;
            //return Kvadrat(beroj) * beroj * beroj;
            //return Kvadrat(Kvadrat(beroj));
            return (int)Math.Pow(beroj, 4);  // zato što math.pow vraća double
        }

        private static int Kub(int beroj)
        {
            return Kvadrat(beroj) * beroj;
        }

        private static int Kvadrat(int beroj)
        {
            return beroj * beroj;
        }
    }
}
