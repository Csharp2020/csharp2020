using System;

namespace _5._3._12_suma_i_Prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum=0;
            float prosjek=0;
            for(int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            prosjek = sum/ 5;
            Console.WriteLine("Sum: {0}, Prosjek: {1}", sum, prosjek);
        }
    }
}
