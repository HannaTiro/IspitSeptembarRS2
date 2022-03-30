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
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;
        public KupciController(IKupciService service)
        {
            _service = service;
        }
        [HttpGet]
        public IList<Model.Kupci> GetAll([FromQuery] KupciSearchRequest search)
        {
            return _service.GetAll(search);
        }

    }
}
