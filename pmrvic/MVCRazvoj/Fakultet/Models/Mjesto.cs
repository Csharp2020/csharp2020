using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fakultet.Models
{
    public partial class Mjesto
    {
        public Mjesto()
        {
            Nastavnik = new HashSet<Nastavnik>();
            StudPbrRodNavigation = new HashSet<Stud>();
            StudPbrStanNavigation = new HashSet<Stud>();
        }

        [Display(Name = "Poštanski broj")]
        public int Pbr { get; set; }

        [Display(Name = "Naziv mjesta")]
        public string NazMjesto { get; set; }

        [Display(Name = "Odaberi županiju")]
        public short? SifZupanija { get; set; }

        [Display(Name = "Naziv županije")]
        public virtual Zupanija SifZupanijaNavigation { get; set; }
        public virtual ICollection<Nastavnik> Nastavnik { get; set; }
        public virtual ICollection<Stud> StudPbrRodNavigation { get; set; }
        public virtual ICollection<Stud> StudPbrStanNavigation { get; set; }
    }
}
