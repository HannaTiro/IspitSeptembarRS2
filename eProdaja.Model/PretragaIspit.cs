using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
   public partial class PretragaIspit
    {
        public int PretragaIspitId { get; set; }
        public  VrsteProizvodum VrstaProizvoda { get; set; }
        public int? VrstaProizvodaId { get; set; }
        public  Kupci Kupac { get; set; }
        public int? KupacId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public decimal IznosPrometa { get; set; }
        public decimal ProsjecniPromet { get; set; }
    }
}
