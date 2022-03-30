using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
   public  class PretragaIspiInsertRequest
    {
       
        public int VrstaProizvodaId { get; set; }
       
        public int KupacId { get; set; }
        public decimal MinIznosPrometa { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public decimal IznosPrometa { get; set; }
    }
}
