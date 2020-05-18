using System;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {  // od teksta ispisi 2 po 2 znaka
            // Bio sam u zoološkom vrtu
            //biamooškvr
           
            string recenica = "Bio sam u zooloskom vrtu";
            recenica = recenica.Replace(" ", "");
            for (int i = 0; i < recenica.Length; i += 4)
            {
                Console.Write(recenica.Substring(i, 2));
            }

        }
    }
}
