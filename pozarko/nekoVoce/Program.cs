using System;
using System.Collections.Generic;

namespace nekoVoce
{
    class Program
    {
        static void Main(string[] args)
        {
            jediJabuke();
            jediNarance();
            jediBanane();
        }
        private static void jediJabuke()
        {
            Apple a1 = new Apple();
            a1.Boja = "Crvena";
            Apples k1 = new Apples();
            k1.Add(a1);
            foreach (var item in k1)
            {
                k1.ispis(item);
            }
        }

        private static void jediBanane()
        {
            Banana b1 = new Banana();
            b1.Boja = "Zuta";
            Banana[] banane = new Banana[3];
            banane[0] = b1;
            foreach (var item in banane)
            {
                Console.WriteLine(item);
            }
        }

        private static void jediNarance()
        {
            Naranca n1 = new Naranca();
            Console.WriteLine("Boja narance");
            n1.Boja = Console.ReadLine();
            List<Naranca> narance = new List<Naranca>();
            narance.Add(n1);
            foreach (var item in narance)
            {
                Console.WriteLine(item.Boja);
            }
        }


    }
}
