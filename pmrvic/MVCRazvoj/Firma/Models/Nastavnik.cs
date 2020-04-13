using System;
using System.Collections.Generic;

namespace Firma.Models
{
    public partial class Nastavnik
    {
        public int SifNastavnik { get; set; }
        public string ImeNastavnik { get; set; }
        public string PrezNastavnik { get; set; }
        public int PbrStan { get; set; }
        public int SifOrgjed { get; set; }
        public decimal Koef { get; set; }
    }
}
