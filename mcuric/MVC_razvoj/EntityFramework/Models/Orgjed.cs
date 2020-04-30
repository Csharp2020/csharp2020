using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public partial class Orgjed
    {
        public Orgjed()
        {
            InverseSifNadorgjedNavigation = new HashSet<Orgjed>();
            Nastavnik = new HashSet<Nastavnik>();
            Pred = new HashSet<Pred>();
        }

        public int SifOrgjed { get; set; }
        [Display(Name = "Organizacijska jedinica")]
        public string NazOrgjed { get; set; }
        public int? SifNadorgjed { get; set; }

        [Display(Name = "Nadređena org. jedinica")]
        public virtual Orgjed SifNadorgjedNavigation { get; set; }
        public virtual ICollection<Orgjed> InverseSifNadorgjedNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavnik { get; set; }
        public virtual ICollection<Pred> Pred { get; set; }
    }
}
