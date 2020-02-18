using System;

namespace _8_1_2_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");

            Ucenik marko = new Ucenik("Marko", "Curic");
            marko.mathGrade = 5;
            marko.englishGrade = 5;
            marko.biologyGrade = 3;

            Profesor mProfesor = new Profesor("Branka","Kolar");
            mProfesor.profession = "math";

            Profesor eProfesor = new Profesor("Stefania", "Bogicevic");
            eProfesor.profession = "english";

            Profesor bProfesor = new Profesor("Doriann","Gray");
            bProfesor.profession = "biology";

            bProfesor.Odgovor(marko.BiologyGrade());
            Console.WriteLine();
            mProfesor.Odgovor(marko.MathGrade());
            Console.WriteLine();
            eProfesor.Odgovor(marko.EnglishGrade());

            Console.ReadLine();
        }
    }
}
