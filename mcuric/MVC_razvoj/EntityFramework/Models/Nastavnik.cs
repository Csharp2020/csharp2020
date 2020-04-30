using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public partial class Nastavnik
    {
        public int SifNastavnik { get; set; }
        [Display(Name ="Ime nastavnika")]
        public string ImeNastavnik { get; set; }
        [Display(Name = "Prezime nastavnika")]
        public string PrezNastavnik { get; set; }
        public int PbrStan { get; set; }
        public int SifOrgjed { get; set; }
        [Display(Name = "Koeficijent")]
        public decimal Koef { get; set; }

        [Display(Name = "Mjesto stanovanja")]
        public virtual Mjesto PbrStanNavigation { get; set; }
        [Display(Name = "Organizacijska jedinica")]
        public virtual Orgjed SifOrgjedNavigation { get; set; }

        public ICollection<PredNastavnik> PredNastavnik { get; set; }

       // public virtual PredNastavnik PredNastavnikNavigation { get; set; }
    }
}
