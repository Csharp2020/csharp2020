using System;
using System.Collections;
using System.Collections.Generic;

namespace zadatak_voce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fruit lovers!");
            Banana b1 = new Banana(15);
            Banana b2 = new Banana(23);
            Banana[] bananas = new Banana[2] { b1, b2 };

            Orange o1 = new Orange(5.2);
            Orange o2 = new Orange(3.7);
            List<Orange> oranges = new List<Orange>();
            oranges.Add(o1);
            oranges.Add(o2);

            Apple a1 = new Apple(2);
            Apple a2 = new Apple(3);
            Apples apples = new Apples();
            apples.Add(a1);
            apples.Add(a2);

            Console.WriteLine("Sve banane: ");
            for (int i=0; i< bananas.Length; i++)
            {
                Console.WriteLine("banana, " + bananas[i].Length + " duljine ");
            }

            Console.WriteLine("Sve narance: ");
            foreach (var item in oranges) 
            {
                Console.WriteLine("naranca " + item.Radius + " radijusa");
            }

            apples.Ispis();

            Console.ReadLine();
        }
    }
}
