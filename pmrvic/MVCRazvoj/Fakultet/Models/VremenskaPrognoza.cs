using System;
using System.ComponentModel.DataAnnotations;

namespace Fakultet.Models
{
    public class VremenskaPrognoza
    {
        /* 
        // predlozak JSON WEB API za vremensku prognozu: 
        // https://localhost:44385/api/weatherforecast
        {
        "date": "2020-05-13T20:58:05.681959+02:00",
        "temperatureC": 23,
        "temperatureF": 73,
        "summary": "Freezing"
        },
         */
        [Display(Name = "Datum")]
        public DateTime date;

        [Display(Name = "Temperatura [°C]")]
        public int temperatureC;

        [Display(Name = "Temperatura [°F]")]
        public int temperatureF;

        [Display(Name = "Ikonica")]
        public string summary;
    }
}