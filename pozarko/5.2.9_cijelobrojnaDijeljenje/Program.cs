using System;

namespace _5._2._9_cijelobrojnaDijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 3 == 0){
                Console.WriteLine("Broj je neparan, ostatak pri ijeljenju s 3 iznosi {0}", x%3);
            }
            else {
                Console.WriteLine("Broj je paran");
                Console.WriteLine("Broj nije djeljiv s tri");
            }

        }
    }
}
