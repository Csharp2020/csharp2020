using System;

namespace _7._2._1_potprogram
{
    class Program
    {
        /*Radi lakseg citanja programa i reuse-anja odredenog dijela koda koristimo metode.
        Metode ti mogu objasniti na kreativni nacin na primjeru tvornice auta.
        Ubiti metodu Main mozes zamisliti kao dio tvornice di se sastavlja cijelii dovrsava cijeli auto.
        Dok ostali dijelovi tvornice koriste se za proizvodnju motora, vrata, sistema za kocenje itd.*/

        //U ovome primjeru u metodi Main pozivamo metodu HelloWorld
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                HelloWorld();



                //OVAJ KOMENTAR PROCITAJ NAKON STO SI PROCITAO KOMENTARE IZNAD DEFINICIJE METODE HelloWorld();
                /*Kada bi obrisao static ovako bi pozivao metodu HelloWorld (kod dolje), tako da isprobaj obrisati static
                 kod definicije HelloWorld metode i vidjeti ces da ce ti kod poziva metode iznad ovog komentara izbacivati
                 error.*/

                /*
                Program p = new Program(); 
                p.HelloWorld();
                */
            }
        }


        /*Ovo je definicija metode HelloWorld(), ona je tipa void jer ne vraca nikakve parametre koje mozemo storeati
         u neku varijablu. Svaka metoda koja netreba vratiti parametar definira se sa main.*/

        //static ubiti tu stoji kako bi metoda bila vidljiva svim ostalim metodama u ovom namespaceu (koliko sam ja skonto)
        static void HelloWorld()
        {
            Console.WriteLine("Hello world");
        }
    }
}
