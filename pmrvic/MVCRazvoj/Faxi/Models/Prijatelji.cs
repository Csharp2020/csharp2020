using System;
using System.Collections.Generic;

namespace Faxi.Models
{
    public partial class Prijatelji
    {
        public Prijatelji()
        {
            Evidencije = new HashSet<Evidencije>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public virtual ICollection<Evidencije> Evidencije { get; set; }
    }
}
