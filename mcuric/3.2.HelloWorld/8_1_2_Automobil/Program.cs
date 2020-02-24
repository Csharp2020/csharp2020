using System;
using System.Timers;

namespace _8_1_2_Automobil
{
    class Program
    {
        private static Timer aTimer;

        static void Main(string[] args)
        {
            Console.WriteLine("Opisite automibil za koji zelite izracunati cijenu!");
            Automobil a1 = new Automobil();
            Console.WriteLine("Marka automobila: ");
            a1.MarkaAutomobila = Console.ReadLine();
            Console.WriteLine("KS: ");
            a1.KS = double.Parse(Console.ReadLine());
            Console.WriteLine("Osnovna cijena: ");
            a1.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ukupna cijena danog automobila iznosi: {a1.OsnovnaCijena + a1.OsnovnaCijena * a1.IznosPoreza()}");

            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 5000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }
    }
}
