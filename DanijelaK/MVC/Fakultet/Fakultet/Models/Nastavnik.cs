﻿using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Nastavnik
    {
        public int SifNastavnik { get; set; }
        public string ImeNastavnik { get; set; }
        public string PrezNastavnik { get; set; }
        public int PbrStan { get; set; }
        public int SifOrgjed { get; set; }
        public decimal Koef { get; set; }

        //public virtual PredNastavnik PredNastavnikNavigation { get; set; }
        public virtual Mjesto PbrStanNavigation { get; set; }
        public virtual Orgjed SifOrgjedNavigation { get; set; }

        // pivot tablica:
        public ICollection<PredNastavnik> PredNastavnik { get; set; }
    }
}