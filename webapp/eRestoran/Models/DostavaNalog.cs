using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class DostavaNalog
    {
        public int Id { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public Uposlenik Uposlenik { get; set; }
        public int UposlenikID { get; set; }
        public VoziloZaDostavu VoziloZaDostavu { get; set; }
        public int? VoziloZaDostavuID { get; set; }
    }
}
