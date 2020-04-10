using System;
using System.Collections.Generic;

namespace Firma.Models
{
    public partial class Ispit
    {
        public int MbrStud { get; set; }
        public int SifPred { get; set; }
        public int SifNastavnik { get; set; }
        public DateTime DatIspit { get; set; }
        public short Ocjena { get; set; }
    }
}
