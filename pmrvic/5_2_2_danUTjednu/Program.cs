﻿using System;

namespace _5_2_2_danUTjednu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi dan ui tjednu");
            Console.WriteLine("pon uto sri cet pet sub ned");

            string dan = Console.ReadLine();

            switch (dan)
            {
                case "pon":
                case "uto":
                case "sri":
                case "cet":
                case "pet":
                    Console.WriteLine("radni dan"); break;
                case "sub":
                case "ned":
                    Console.WriteLine("vikend"); break;

                default:
                    Console.WriteLine("nepoznati dan ?!?"); break;

            }
        }
    }
}
