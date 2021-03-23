using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class Meni
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string LinkZaSliku { get; set; }
        public float StanjeNaSkladistu { get; set; }
        public string ZaDostavu { get; set; }
        public string Opis { get; set; }
        public Kategorija Kategorija { get; set; }
        public int KategorijaID { get; set; }

    }
}
