using System;

namespace _9_1_6_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrom");

            //ana voli milovana
            //udovica baci vodu

            string text = Console.ReadLine();
            text = text.Trim();
            text = text.Replace(" ","");
            text = text.ToLower();

            string revesedText="";

            for (int i = text.Length-1; i >= 0 ; i--)
            {
                revesedText += text[i];
            }
            Console.WriteLine(revesedText);

            if (text.Equals(revesedText))
            {
                Console.WriteLine(text + "je palindrom");
            }
            else
            {
                Console.WriteLine("NIJE je palindrom");
            }

            bool status = true;
            for (int i = 0 ; i < text.Length; i++)
            {
                if (text[i]==text[text.Length-i-1])
                {
                    status = true;
                }
                else
                {
                    status = false;
                    break;
                }
            }
            if (status)
            {
                Console.WriteLine(text + "je palindrom");
            }
            else
            {
                Console.WriteLine("NIJE je palindrom");
            }

        }
    }
}
