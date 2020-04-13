using System;
using System.Collections.Generic;

namespace Firma.Models
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
    }
}
