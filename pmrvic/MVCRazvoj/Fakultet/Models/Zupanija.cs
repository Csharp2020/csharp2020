using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fakultet.Models
{
    public partial class Zupanija
    {
        
        string nazZupanija; // privremeno polje za vrijednosti bez whitespacea (razmaka)
        public Zupanija()  //konstruktor u kojemu definiramo relacije
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }

        [Display(Name = "Naziv županije")]
        public string NazZupanija {  // sadrzi razmake koje trebamo maknuti
            get => Lib.UCFirst.UpperCaseMe(nazZupanija.Trim()); // Mutators, u letu preoblikuje povratni tip
            set => nazZupanija = Lib.UCFirst.UpperCaseMe(value.Trim()); 
        }

        public virtual ICollection<Mjesto> Mjesto { get; set; }
        
    }
}
