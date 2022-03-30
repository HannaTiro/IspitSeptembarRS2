using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
   public  interface IPretragaIspitService
    {
        IList<Model.PretragaIspit> GetAll(PretragaIspitSearchRequest search);
        Model.PretragaIspit Insert(PretragaIspiInsertRequest request);
    }
}
