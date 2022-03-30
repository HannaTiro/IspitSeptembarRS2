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
    public class IzlaziController : ControllerBase
    {
        private readonly IIzlaziService _service;
        public IzlaziController(IIzlaziService service)
        {
            _service = service;
        }
        [HttpGet]
     public    IList<Model.Izlazi> GetAll([FromQuery]IzlaziSearchRequest search)
        {
            return _service.GetAll(search);
        }


    }
}
