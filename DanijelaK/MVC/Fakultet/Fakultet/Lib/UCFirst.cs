using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fakultet.Lib
{
    public static class UCFirst
    {
        public static string UpperCaseME(string value)
        {
            return value.First().ToString().ToUpper() + value.Substring(1);
        }
    }
}
