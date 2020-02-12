using System;

namespace _5_3_11_savrseni_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj:");

              //  int a = int.Parse(Console.ReadLine());
                for (int a = 1; a < 1000; a++)
                {

                
                int broj = 0;

                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        broj += i;  // broj=broj+i;
                    }
                }
                


                if (a == broj)
                {
                    Console.Write("{0} ",a);
                }

                else
                {
                   // Console.WriteLine("Unešeni broj nije savršen.");
                }
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
