using System;
using System.Collections.Generic;

namespace Faxi.Models
{
    public partial class Mediji
    {
        public Mediji()
        {
            Evidencije = new HashSet<Evidencije>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Vrsta { get; set; }

        public virtual ICollection<Evidencije> Evidencije { get; set; }
    }
}
