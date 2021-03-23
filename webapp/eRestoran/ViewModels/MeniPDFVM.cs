using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.ViewModels
{
    public class MeniPDFVM
    {
        public List<RowTjestenina> TjesteninaRows { get; set; }
        public List<RowSendvici> SendviciRows { get; set; }
        public List<RowSchnitzel> SchnitzelRows { get; set; }
        public List<RowDeserts> DesertsRows { get; set; }
        public List<RowBeefsteak> BeefsteakRows { get; set; }
        public class RowTjestenina
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
        public class RowSendvici
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
        public class RowBeefsteak
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
        public class RowSchnitzel
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
        public class RowDeserts
        {
            public int ID { get; set; }
            public string LinkZaSliku { get; set; }
            public float Cijena { get; set; }
            public string Naziv { get; set; }
            public int KategorijaID { get; set; }
        }
    }
}

