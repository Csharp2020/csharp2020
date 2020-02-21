using System;

namespace _7._2._2_unosImena
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozdrav("Pero");
            Pozdrav("Pero", "Peric"); //Pozdrav#2
            Pozdrav(v2:"Pero", v1:"Peric", v3:2021);//Odredili smo redoslijed parametara
        }

        private static void Pozdrav(string v1, string v2,int v3=0) //Pozdrav#2 nebi funkcionirao ako neodredimo default od v3
        {
            //Opcija 1
            //Console.WriteLine("Pozdrav {0} {1}!" ,v1, v2);
            Pozdrav(v1);
            Console.Write(" {0}", v2);
        }

        private static void Pozdrav(string v)
        {
            Console.WriteLine("Pozdrav "+v);
        }
    }
}
