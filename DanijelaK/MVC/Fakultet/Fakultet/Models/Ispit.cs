using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Ispit
    {
        public int MbrStud { get; set; }
        public int SifPred { get; set; }
        public int SifNastavnik { get; set; }
        public DateTime DatIspit { get; set; }
        public short Ocjena { get; set; }

        public virtual Stud MbrStudNavigation { get; set; }
        public virtual Nastavnik SifNastavnikNavigation { get; set; }
        public virtual Pred SifPredNavigation { get; set; }
    }
}
