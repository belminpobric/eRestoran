using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class OnlineNarudzba
    {
        public int Id { get; set; }
        [Display(Name = "Naziv Jela")]
        public string NazivJela { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [Display(Name = "Datum Narudzbe")]
        public DateTime DatumNarudzbe { get; set; }
        public float Cijena { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public DostavaNalog DostavaNalog { get; set; }
        public int? DostavaNalogID { get; set; }

    }
}
