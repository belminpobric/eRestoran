using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace eRestoran.ViewModels
{
    public class OnlineNarudzbaVM
    {

        public int NarudzbaID { get; set; }
        public string NazivJela { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public float Cijena { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
    }
}
