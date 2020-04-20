using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Lib
{
    public static class FirstUpper
    {
        public static string UCFirst(string ulaz)
        {
            {
                return ulaz.First().ToString().ToUpper() + ulaz.Substring(1);
            }
        }
    }
}
