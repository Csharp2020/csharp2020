using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public partial class Stud
    {
        public int MbrStud { get; set; }
        private string imeStud;
        [Display(Name = "Ime studenta")]
        public string ImeStud
        {
            get
            {
                return Lib.FirstUpper.UCFirst(imeStud);
            }
            set
            {
                imeStud = Lib.FirstUpper.UCFirst(value.Trim());
            }
        }
        private string prezStud;
        [Display(Name = "Prezime studenta")]
        public string PrezStud
        {
            get
            {
                return Lib.FirstUpper.UCFirst(prezStud);
            }
            set
            {
                prezStud = Lib.FirstUpper.UCFirst(value.Trim());
            }
        }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Datum rođenja")]
        public DateTime? DatRodStud { get; set; }
        [Display(Name = "JMBG")]
        public string JmbgStud { get; set; }

        [Display(Name = "Mjesto rođenja")]
        public virtual Mjesto PbrRodNavigation { get; set; }
        [Display(Name = "Boravište/Prebivalište")]
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}
