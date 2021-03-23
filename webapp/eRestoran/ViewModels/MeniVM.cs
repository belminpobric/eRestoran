using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.ViewModels
{
    public class MeniVM
    {
        public int ID { get; set; }
        public string naziv { get; set; }
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
    }
}
