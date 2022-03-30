using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PretragaIspitController : ControllerBase
    {

        private readonly IPretragaIspitService _service;
        public PretragaIspitController(IPretragaIspitService service)
        {
            _service = service;
        }
        [HttpGet]
       public IList<Model.PretragaIspit> GetAll([FromQuery]PretragaIspitSearchRequest search)
        {
            return _service.GetAll(search);
        }
        [HttpPost]
      public  Model.PretragaIspit Insert([FromBody]PretragaIspiInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
