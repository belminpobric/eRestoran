using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class StavkaUlaza
    {
        public int Id { get; set; }
        public string Kolicina { get; set; }
        public UlazUSkladiste UlazUSkladiste { get; set; }
        public int UlazUSkladisteID { get; set; }
        public Meni Meni { get; set; }
        public int MeniID { get; set; }
    }
}
