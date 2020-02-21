using System;

namespace _8_Auto_speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto a1 = new Auto("Nissan", "Qashqai", 130);

            a1.Ubrzaj(acc_level: 10, acc_time: 5);  // index ubrzanja [1-10], trajanje ubrzanja [s]
            a1.Ubrzaj(acc_level: 1, acc_time: 10);
            a1.Ubrzaj(acc_level: 5, acc_time: 5);
            a1.Ubrzaj(acc_level: 10, acc_time: 10);

            Chart.DrawChart(a1.dijagramBrzine);
            
            Console.ReadKey();

        }
        
    }
}
