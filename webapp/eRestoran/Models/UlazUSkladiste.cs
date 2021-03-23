using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class UlazUSkladiste
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public float KolicinaUlaza { get; set; }
        public string ImeDobavljaca { get; set; }
        public DateTime DatumPrijema { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int UposlenikID { get; set; }
    }

}
