using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public partial class PretragaIspit
    {
        public int PretragaIspitId { get; set; }
        public virtual VrsteProizvodum VrstaProizvoda { get; set; }
        public int? VrstaProizvodaId { get; set; }
        public virtual Kupci Kupac { get; set; }
        public int?  KupacId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public decimal IznosPrometa { get; set; }
       
    }
}
