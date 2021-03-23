using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class NarudzbaStavka
    {
        public int Id { get; set; }
        public string Kolicina { get; set; }
        public Meni Meni { get; set; }
        public int MeniID { get; set; }
        public DnevnaPonuda DnevnaPonuda { get; set; }
        public int DnevnaPonudaID { get; set; }
        public OnlineNarudzba OnlineNarudzba { get; set; }
        public int OnlineNarudzbaID { get; set; }
    }
}
