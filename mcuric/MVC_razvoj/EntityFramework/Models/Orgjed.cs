using System;
using System.Collections.Generic;

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
        public string NazOrgjed { get; set; }
        public int? SifNadorgjed { get; set; }

        public virtual Orgjed SifNadorgjedNavigation { get; set; }
        public virtual ICollection<Orgjed> InverseSifNadorgjedNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavnik { get; set; }
        public virtual ICollection<Pred> Pred { get; set; }
    }
}
