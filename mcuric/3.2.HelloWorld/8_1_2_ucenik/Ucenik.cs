using System;
using System.Collections.Generic;
using System.Text;
using _8_1_3_osoba;

namespace _8_1_2_ucenik
{
    class Ucenik
    {
        public DateTime dateTime;
        public string firstName = "";
        public string lastName = "";
        public int mathGrade = 0;
        public int biologyGrade = 0;
        public int englishGrade = 0;

        public Ucenik()
        {
            dateTime = DateTime.Now;
        }

        public Ucenik(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double Average()
        {
            return (double)(mathGrade + biologyGrade + englishGrade) / 3;
        }

        public int MathGrade()
        {
            int a = this.mathGrade;
            Console.WriteLine("Hi, my name is {0} and my math grade is {1}", this.firstName, a);
            return a;
        }

        public int BiologyGrade()
        {
            int a = this.biologyGrade;
            Console.WriteLine("Hi, my name is {0} and my Biology grade is {1}", this.firstName, a);
            return a;
        }

        public int EnglishGrade()
        {
            int a = this.englishGrade;
            Console.WriteLine("Hi, my name is {0} and my English grade is {1}", this.firstName, a);
            return a;
        }
    }
}
