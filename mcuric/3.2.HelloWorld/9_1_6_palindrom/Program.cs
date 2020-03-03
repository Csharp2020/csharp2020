using System;

namespace _9_1_6_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite rijec!");
            string tekst = Console.ReadLine();
            Boolean status = true;
            tekst = tekst.Replace(" ","");
            tekst = tekst.ToLower();
            for(int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == tekst[tekst.Length - i - 1])
                {
                    status = true;
                }
                else { status = false;
                    break;
                }
            }
            if (status)
            {
                Console.WriteLine("Dani tekst je palindrom!");
            }
            else
            {
                Console.WriteLine("Dani tekst nije palindrom!");
            }

            Console.ReadLine();
        }
    }
}
