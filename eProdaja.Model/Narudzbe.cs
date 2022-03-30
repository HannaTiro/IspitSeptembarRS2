using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public partial class Narudzbe
    {
        public int NarudzbaId { get; set; }
        public int KupacId { get; set; }
        public Kupci Kupac { get; set; }
    }
}
