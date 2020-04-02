using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Kontrolori.Models
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime{ get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DatumRodjenja { get; set; }  // moze biti NULL
    }
}
