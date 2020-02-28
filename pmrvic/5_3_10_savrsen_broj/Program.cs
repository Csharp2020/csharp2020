using System;

namespace _5_3_10_savrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj:");
                int a = int.Parse(Console.ReadLine());

                int broj = 0;

                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        broj += i;

                    }
                }


                if (a == broj)
                {
                    Console.WriteLine("Unešeni broj je savršen.");
                }

                else
                {
                    Console.WriteLine("Unešeni broj nije savršen.");
                }

            }

            catch (FormatException fex)
            {
                Console.WriteLine("Krivi format unosa (nije unesen broj)" + fex.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine("GREŠKA: uneseni broj nije ispravan" + ex.ToString());
            }

        }
    }
}
