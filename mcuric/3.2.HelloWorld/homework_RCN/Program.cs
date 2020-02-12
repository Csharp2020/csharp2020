using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_RCN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sum you want to be determined!");
            string entry = Console.ReadLine();  //unos izraza za racunanje
            int l = entry.Length;
            Console.WriteLine("You entered: {0}", entry);
            string[] particles = new string[l];
            string[] operators = new string[l];
            int k = 0;
            for (int i = 0; i < l; i++)
            {
                string helper = entry.Substring(i, 1);
                //Provjera vrijednosti svakog pojedinog znaka u unesenom stringu
                //Console.WriteLine("Vrijednost substringa je "+helper);
                if (helper != "+" && helper != "-" && helper != "*" && helper != "/")
                {
                    particles[k] += helper;
                    operators[k] = " ";

                    //Console.WriteLine("IF dio" + k);
                }
                else
                {
                    k++;
                    particles[k] = " ";
                    operators[k-1] += helper;
                    //Console.WriteLine("ELSE dio" + k);
                }
            }
            float[] numbers = new float[particles.Length];
            //novi array float brojeva
            for(int j = 0; j < l; j++)
            {
                if (particles[j] != null)
                    numbers[j] = float.Parse(particles[j]);
                else
                    numbers[j] = 0;
            }
            float[] brojevi = new float[l / 2 + 1];
            for(int n = 0; n < l / 2 + 1; n++)
            {
                if (numbers[n] != 0) brojevi[n] = numbers[n];
            }
            /*String[] operators2 = new String[l];
            for(int m = 0; m < l; m++)
            {
                operators2[m] = operators[m];
            }
            Array.Sort(operators2, StringComparer.Ordinal);*/
            //KeyValue parovi radi lakse kontrole nad operacijama
            var list = new List<KeyValuePair<float, string>>();
            for(int n = 0; n < l; n++)
            {
                list.Add(new KeyValuePair<float, string>(n, operators[n]));
            }
            list = list.OrderBy(x => x.Value).ToList();
            list.RemoveRange(0, l/2+1);
            //Provjera Keyvalue parova
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            float rezultat = 0;
            foreach (var item in list)
            {
                if (item.Value == " +")
                {
                    int sub = (int)(item.Key);
                    rezultat += (brojevi[sub]+brojevi[sub+1]);
                    Console.WriteLine("Dva broja s kojima trenutno radim su: {0} i {1}", brojevi[sub], brojevi[sub+1]);
                    brojevi[sub] = brojevi[sub] + brojevi[sub + 1];
                    brojevi[sub + 1] = 0;
                }
                if (item.Value == " -")
                {
                    int sub = (int)(item.Key);
                    rezultat += (brojevi[sub] - brojevi[sub + 1]);
                    Console.WriteLine("Dva broja s kojima trenutno radim su: {0} i {1}", brojevi[sub], brojevi[sub + 1]);
                    brojevi[sub] = brojevi[sub] - brojevi[sub + 1];
                    brojevi[sub + 1] = 0;
                }
                if (item.Value == " *")
                {
                    int sub = (int)(item.Key);
                    rezultat += (brojevi[sub] * brojevi[sub + 1]);
                    Console.WriteLine("Dva broja s kojima trenutno radim su: {0} i {1}", brojevi[sub], brojevi[sub + 1]);
                    brojevi[sub] = brojevi[sub] * brojevi[sub + 1];
                    brojevi[sub + 1] = 0;
                }
                if (item.Value == " /")
                {
                    int sub = (int)(item.Key);
                    rezultat += (brojevi[sub] / brojevi[sub + 1]);
                    Console.WriteLine("Dva broja s kojima trenutno radim su: {0} i {1}", brojevi[sub], brojevi[sub + 1]);
                    brojevi[sub] = brojevi[sub] / brojevi[sub + 1];
                    brojevi[sub + 1] = 0;
                }
            }

            Console.WriteLine("Resulting number is: {0}", rezultat);
            
            /*
            foreach (var item in brojevi)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Ukupno elemenata {0}", particles.Length);
            Console.WriteLine("Ukupno operatora {0}", operators.Length);
            foreach (var item in particles)
            {
                Console.Write(item);
            }
            Console.WriteLine(" ");*/
            /*
            foreach (var item in operators)
            {
                Console.Write(item);
            }
            */
            Console.ReadLine();
        }
    }
}
