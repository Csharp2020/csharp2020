using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fakultet.Models
{
    public partial class Zupanija
    {
        string nazZupanija;
        public Zupanija() // konstruktor u kojemu definiramo županije
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }
        
        [Display(Name = "Naziv županije")]
        public string NazZupanija {
            get => Lib.UCFirst.UpperCaseME(nazZupanija.Trim()); // mutators, u letu preoblikuje povratni tip
            set => nazZupanija = Lib.UCFirst.UpperCaseME(value.Trim());
        }
        
        public virtual ICollection<Mjesto> Mjesto { get; set; }
        
    }
}
