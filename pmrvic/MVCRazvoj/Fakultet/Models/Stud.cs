using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Stud
    {
        public int MbrStud { get; set; }
        public string ImeStud { get; set; }
        public string PrezStud { get; set; }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        public DateTime? DatRodStud { get; set; }
        public string JmbgStud { get; set; }

        public virtual Mjesto PbrRodNavigation { get; set; }
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}
