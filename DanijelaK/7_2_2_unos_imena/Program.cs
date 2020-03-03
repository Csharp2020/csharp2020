using System;

namespace _7_2_2_unos_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispisuje ime i pozdrav");
            Pozdrav("Pero");
            Console.WriteLine();
            Pozdrav("Pero", "Perić");
            Console.WriteLine();
            Pozdrav("Pero", "Perić", 2021);
            Console.WriteLine();
            Pozdrav(v2: "Pero", v1: "Perić", v3: 2021); //Zamijenili smo redosljed
        }

        private static void Pozdrav(string v1, string v2, int v3=0)
        {
            // Opcija 1
            //Console.WriteLine("Pozdrav {0} {1}!", v1, v2);
            Pozdrav(v1);
            Console.Write(" {0}", v2 );
            if (v3!=0)
            {
                Console.Write(". Sretna Nova godina {0}!", v3);
            }
        }

        private static void Pozdrav(string v)
        {
            Console.Write("Pozdrav {0}", v);
        }
    }
}
