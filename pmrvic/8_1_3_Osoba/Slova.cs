using System;
using System.Linq;

namespace _8_1_3_Osoba
{
    public static class Slova
    {
        public static string PrvoVeliko(string value)
        {
            value = value.Trim();  // brise praznine sa početka i kraja stringa
            return char.ToUpper(value.First()) + value.Substring(1).ToLower();  // prvo velko
        }
    }
}