using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class Obavijesti
    {
        
        public int Id { get; set; }
        public string Poruka { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public IEnumerable<UposlenikObavijesti> Uposlenik { get; set; }
    }
}
