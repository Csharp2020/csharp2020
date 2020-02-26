using System;

namespace _7._2._2_unosImena
{
    class Program
    {
        //Svi komentari koji zapocinju sa - su napravljeni na predavanju.

        /*U ovom programu uveli smo parametre u metode. Ti parametri sluze kako bi predali neku vrijednost metodama
         koju ocekujemo da ce one obraditi. Kao sto vidis opet su tipa void jer ne ocekujemo povratnu vrijednost koju
         bi storeali u neku varijablu. Prvo smo napravili Metodu#1 tek onda Metodu#2.*/
        static void Main(string[] args)
        {
            Pozdrav("Pero");//Pozdrav#1  //Predajemo joj vrijednosti "Pero" 
            Pozdrav("Pero", "Peric"); //Pozdrav#2  //Predajemo joj vrijednost "Pero" i vrijednost "Peric"
            Pozdrav(v2:"Pero", v1:"Peric", v3:2021);//-Odredili smo redoslijed parametara //Pozdrav#3
        }
        /*Metoda se moze definirati sa koliko god parametara zelis no onda moras znati koliko bi minimalno vrijednosti 
         predavao toj metodi te ostalim parametrima bi trebao odrediti defaultnu vrijednost. Procitaj komentar sa sata
         desno od definicije metode #2. Kod treceg parametra(v3) probaj obrisati =0 i vidjeti ces da ce ti nastati error
         kod Pozdrav#2*/
         //Isto tako kada bi obrisali Metodu#1 onda bi i za v2 morali odrediti default vrijednost jer ni Pozdrav #1 ni #2 nebi radili

        //Metoda#2
        private static void Pozdrav(string v1, string v2,int v3=0)//-Pozdrav#2 nebi funkcionirao ako neodredimo default od v3
        {
            //-Opcija 1
            Console.WriteLine("Pozdrav {0} {1}!" ,v1, v2);
            
            //-Opcija 2
            //-Pozdrav(v1);
            //-Console.Write(" {0}", v2);
        }


        //Metoda#1
        private static void Pozdrav(string v)
        {
            Console.WriteLine("Pozdrav "+v);
        }
    }
}
