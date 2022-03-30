using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KupciService:IKupciService
    {
        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;
        public KupciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Kupci> GetAll(KupciSearchRequest search)
        {
            var request = _context.Kupcis.AsQueryable();
            if (search?.KupacId != null)
            {
                request = request.Where(x => x.KupacId == search.KupacId);
            }
            var podaci = request.ToList();
            return _mapper.Map<IList<Model.Kupci>>(podaci);
        }
    }
}
