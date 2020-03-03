using System;

namespace zoloskiVrt
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bio sam u zoloskom vrtu";
            a=a.Replace(" ", "");
            for(int i = 0; i < a.Length; i += 4)
            {
                Console.WriteLine(a.Substring(i, 2));
            }
        }
    }
}
