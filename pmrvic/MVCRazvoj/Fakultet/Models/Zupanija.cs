using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fakultet.Models
{
    public partial class Zupanija
    {
        
        string nazZupanija;
        public Zupanija()
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }

        [Display(Name = "Naziv županije")]
        public string NazZupanija { 
            get => nazZupanija.Trim(); // Mutators, u letu preoblikuje povratni tip
            set => nazZupanija = value.Trim(); }

        public virtual ICollection<Mjesto> Mjesto { get; set; }
        
    }
}
