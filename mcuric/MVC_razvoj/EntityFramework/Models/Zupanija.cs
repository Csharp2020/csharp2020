using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework.Lib;

namespace EntityFramework.Models
{
    public partial class Zupanija
    {
        public Zupanija()
        {
            Mjesto = new HashSet<Mjesto>();
        }

        private string nazZupanija;

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public virtual short SifZupanija { get; set; }

        public short SifZupanija { get; set; }
        public string NazZupanija { 
            get {
                return Lib.FirstUpper.UCFirst(nazZupanija.Trim());
            }
            set {
                nazZupanija = Lib.FirstUpper.UCFirst(value.Trim());
            } }

        public virtual ICollection<Mjesto> Mjesto { get; set; }
    }
}
