using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Stud
    {
        private string imeStud;
        private string prezStud;

        public int MbrStud { get; set; }
        public string ImeStud
        { // mutatori, prvo veliko slovo i brisem whitespace
            get => Lib.UCFirst.UpperCaseMe(imeStud.Trim());
            set => imeStud = Lib.UCFirst.UpperCaseMe(value.Trim());
        }
        public string PrezStud
        { // mutatori
            get => Lib.UCFirst.UpperCaseMe(prezStud.Trim());
            set => prezStud = Lib.UCFirst.UpperCaseMe(value.Trim());
        }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        public DateTime? DatRodStud { get; set; }
        public string JmbgStud { get; set; }

        public virtual Mjesto PbrRodNavigation { get; set; }
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}