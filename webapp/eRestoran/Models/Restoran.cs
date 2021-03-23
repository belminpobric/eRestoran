using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class Restoran
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Vlasnik { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        
    }
}
