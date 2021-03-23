using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public partial class UposlenikObavijesti
    {
        public  Uposlenik Uposlenik { get; set; }
        public int UposlenikId { get; set; }
        public Obavijesti Obavijesti { get; set; }
        public int ObavijestiId { get; set; }
    }
}
