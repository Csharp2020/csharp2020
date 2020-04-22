using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Mjesto
    {
        public Mjesto()
        {
            Nastavnik = new HashSet<Nastavnik>();
            StudPbrRodNavigation = new HashSet<Stud>();
            StudPbrStanNavigation = new HashSet<Stud>();
        }

        public int Pbr { get; set; }
        public string NazMjesto { get; set; }
        public short? SifZupanija { get; set; }

        public virtual Zupanija SifZupanijaNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavnik { get; set; }
        public virtual ICollection<Stud> StudPbrRodNavigation { get; set; }
        public virtual ICollection<Stud> StudPbrStanNavigation { get; set; }
    }
}
