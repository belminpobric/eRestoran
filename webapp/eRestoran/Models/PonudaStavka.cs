using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class PonudaStavka
    {
        public int Id { get; set; }
        public string DostupnaKolicina { get; set; }
        public Meni Meni { get; set; }
        public int MeniID { get; set; }
        public DnevnaPonuda DnevnaPonuda { get; set; }
        public int? DnevnaPonudaID { get; set; }
    }
}
