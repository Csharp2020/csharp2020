using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fakultet.Models
{
    public partial class Stud
    {
        private string imeStud;
        private string prezStud;
        private string jmbgStud;

        public int MbrStud { get; set; }
        [Display(Name ="Ime")]
        public string ImeStud { // mutatori, prvo veliko slovo i brisem whitespace
            get => Lib.UCFirst.UpperCaseMe(imeStud.Trim());
            set => imeStud = Lib.UCFirst.UpperCaseMe(value.Trim()); 
        }
        [Display(Name = "Prezime")]
        public string PrezStud { // mutatori
            get => Lib.UCFirst.UpperCaseMe(prezStud.Trim());
            set => prezStud = Lib.UCFirst.UpperCaseMe(value.Trim());
        }
        [Display(Name = "Mjesto rođenja")]
        public int? PbrRod { get; set; }
        [Display(Name = "Mjesto stanovanja")]
        public int PbrStan { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum rođenja")]
        public DateTime? DatRodStud { get; set; }

        /**
         * VALIDACIJA:
         * <see cref="https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1"/>
         * */
        [Display(Name = "JMBG")]
        [StringLength(13, ErrorMessage = "JMBG mora biti točno 13 znakova.", MinimumLength = 13)]
        public string JmbgStud {
            get => jmbgStud == null ? jmbgStud:jmbgStud.Trim();
            set => jmbgStud = value.Trim();
        }

        [Display(Name = "Mjesto rođenja")]
        public virtual Mjesto PbrRodNavigation { get; set; }
        [Display(Name = "Mjesto stanovanja")]
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}
