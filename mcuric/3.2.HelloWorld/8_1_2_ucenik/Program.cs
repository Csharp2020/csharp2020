using System;

namespace _8_1_2_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            //enkapsulacija = postavljanje novog propertija kojim se postavlja i dohvaca property ( set/get )
            // field ime, property Ime

            Console.WriteLine("Hello World! \n");

            Ucenik marko = new Ucenik("Marko", "Curic")
            {
                mathGrade = 5,
                englishGrade = 5,
                biologyGrade = 3
            };

            Ucenik ivan = new Ucenik("Ivan", "Curic")
            {
                mathGrade = 2,
                englishGrade = 5,
                biologyGrade = 4
            };

            Profesor mProfesor = new Profesor("Branka", "Kolar")
            {
                profession = "math"
            };

            Profesor eProfesor = new Profesor("Stefania", "Bogicevic")
            {
                profession = "english"
            };

            Profesor bProfesor = new Profesor("Doriann", "Gray")
            {
                profession = "biology"
            };

            bProfesor.Odgovor(marko.BiologyGrade());
            Console.WriteLine();
            mProfesor.Odgovor(marko.MathGrade());
            Console.WriteLine();
            eProfesor.Odgovor(marko.EnglishGrade());
            Console.WriteLine();

            bProfesor.Odgovor(ivan.BiologyGrade());
            Console.WriteLine();
            mProfesor.Odgovor(ivan.MathGrade());
            Console.WriteLine();
            eProfesor.Odgovor(ivan.EnglishGrade());

            Console.ReadLine();
        }
    }
}
