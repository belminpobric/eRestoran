using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class RezervacijaStolova
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [Display(Name = "Broj osoba")]
        public int BrojOsoba { get; set; }
        [Display(Name = "Vrijeme rezervacije")]
        public DateTime VrijemeRezervacije { get; set; }
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }
    }
}
