using System;
using System.Collections.Generic;

#nullable disable

namespace eProdaja.Database
{
    public partial class VrsteProizvodum
    {
        public VrsteProizvodum()
        {
            Proizvodis = new HashSet<Proizvodi>();
            PretragaIspit = new HashSet<PretragaIspit>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodis { get; set; }
        public virtual ICollection<PretragaIspit> PretragaIspit { get; set; }

    }
}
