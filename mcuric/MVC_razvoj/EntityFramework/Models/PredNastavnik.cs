using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class PredNastavnik
    {
        public int SifNastavnik { get; set; }
        public int SifPred { get; set; }
        public Nastavnik Nastavnik { get; set; }
        public Pred Predmet { get; set; }
    }
}
