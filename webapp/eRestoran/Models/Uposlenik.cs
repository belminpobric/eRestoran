using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class Uposlenik
    {

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Titula { get; set; }
        
        public IEnumerable<UposlenikObavijesti> UposlenikObavijesti { get; set; }
        public Restoran Restoran { get; set; }
        public int RestoranID { get; set; }
    }
}
