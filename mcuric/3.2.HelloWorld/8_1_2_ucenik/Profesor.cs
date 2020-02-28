using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_2_ucenik
{
    class Profesor
    {
        public DateTime dateTime;
        public string firstName = "";
        public string lastName = "";
        public double exp = 0;
        public string profession = "";

        public Profesor()
        {
            dateTime = DateTime.Now;
        }

        public Profesor(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Odgovor(int a)
        {
            Console.WriteLine("Hi, my name is {0} and I'm an {1} teacher! ", this.firstName, this.profession);
            if (profession == "math" && a < 2)
            {
                Console.WriteLine("As a Math teacher I'm disgusted!");
            }
            else if (profession == "math" && a == 2)
            {
                Console.WriteLine("As a Math teacher I'm displeased!");
            }
            else if (profession == "math" && a == 3)
            {
                Console.WriteLine("As a Math teacher I'm fine with that!");
            }
            else if (profession == "math" && a == 4)
            {
                Console.WriteLine("As a Math teacher I'm pretty pleased right now!");
            }
            else if (profession == "math" && a == 5)
            {
                Console.WriteLine("As a Math teacher I'm astonished!");
            }

            if (profession == "biology" && a < 2)
            {
                Console.WriteLine("As a Biology teacher I'm disgusted!");
            }
            else if (profession == "biology" && a == 2)
            {
                Console.WriteLine("As a Biology teacher I'm displeased!");
            }
            else if (profession == "biology" && a == 3)
            {
                Console.WriteLine("As a Biology teacher I'm fine with that!");
            }
            else if (profession == "biology" && a == 4)
            {
                Console.WriteLine("As a Biology teacher I'm pretty pleased right now!");
            }
            else if (profession == "biology" && a == 5)
            {
                Console.WriteLine("As a Biology teacher I'm astonished!");
            }

            if (profession == "english" && a < 2)
            {
                Console.WriteLine("As an English teacher I'm disgusted!");
            }
            else if (profession == "english" && a == 2)
            {
                Console.WriteLine("As an English teacher I'm displeased!");
            }
            else if (profession == "english" && a == 3)
            {
                Console.WriteLine("As an English teacher I'm fine with that!");
            }
            else if (profession == "english" && a == 4)
            {
                Console.WriteLine("As an English teacher I'm pretty pleased right now!");
            }
            else if (profession == "english" && a == 5)
            {
                Console.WriteLine("As an English teacher I'm astonished!");
            }
        }
    }
}
