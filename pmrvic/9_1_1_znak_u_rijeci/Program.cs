using System;

namespace _9_1_1_znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 1 1 znak u rijecui, unesi rijec i jedan znak iz rijeci");

            string rijec = Console.ReadLine();
            string znak = Console.ReadLine();
            int brojznakova = 0;

            //Substring(int startIndex);
            //int IndexOf(String value);

            ////// prvi nacin, rezanjem stringa
            string r = rijec;
            while (r.IndexOf(znak) != -1)
            {
                brojznakova++;
                r=r.Substring(r.IndexOf(znak)+1);
            }
            Console.WriteLine($"Broj znakova '{znak}' u recenici je {brojznakova}");

            ////// drugi nacin
            brojznakova = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if(rijec[i]== char.Parse(znak))
                {
                    brojznakova++;
                }
            }
            Console.WriteLine($"Broj znakova '{znak}' u recenici je {brojznakova}");

            ////// treci nacin
            brojznakova = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if ( rijec[i].ToString()==znak)
                {
                    brojznakova++;
                }
            }
            Console.WriteLine($"Broj znakova '{znak}' u recenici je {brojznakova}");

            ////// cetvrti nacin
            brojznakova = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i].ToString().Equals(znak))
                {
                    brojznakova++;
                }
            }
            Console.WriteLine($"Broj znakova '{znak}' u recenici je {brojznakova}");


        }
    }
}
