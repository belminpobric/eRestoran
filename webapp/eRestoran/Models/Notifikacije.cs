using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.Models
{
    public class Notifikacije
    {
        public int Id { get; set; }
        public string Poruka { get; set; }
        public OnlineGost OnlineGost { get; set; }
        public int OnlineGostID { get; set; }
    }
}
