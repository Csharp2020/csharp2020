using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Firma.Models
{
    
    public class Voce
    {

        //private decimal cijena;  //TODO prebaci ovo u int
       
        [Required]
        [StringLength(10, ErrorMessage = "Ime mora imati manje od 10 znakova")]
        public string Ime { get; set; } // kruska, jabuka...

        [Required]
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] // cijena po kg
        public decimal Cijena   // U Centima, Lipama, Pennies
        { get;set;
           // get => cijena / 100;
           // set => cijena = value * 100;
            }

        [Required]
        [Range(0, 3)]
        [Column(TypeName = "int")]
        public int Kategorija { get; set; } // 0, 1, 2, 3

        public float Kolicina { get; set; }

        public double Ukupno
        {
            get => Decimal.ToDouble(Cijena) * Kolicina;
        }
    }
}
