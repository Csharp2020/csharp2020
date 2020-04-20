using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Stud
    {

        private string imeStud;
        private string prezStud;
        public int MbrStud { get; set; }
        public string ImeStud { 
            get => Lib.UCFirst.UpperCaseME(imeStud.Trim());
            set => imeStud = Lib.UCFirst.UpperCaseME(value.Trim());
        }
        public string PrezStud {
            get => Lib.UCFirst.UpperCaseME(prezStud.Trim());
            set => prezStud = Lib.UCFirst.UpperCaseME(value.Trim());
        }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        public DateTime? DatRodStud { get; set; }
        public string JmbgStud { get; set; }

        public virtual Mjesto PbrRodNavigation { get; set; }
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}
