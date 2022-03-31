using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class PretragaIspitService:IPretragaIspitService
    {

        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;
        public PretragaIspitService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.PretragaIspit> GetAll(PretragaIspitSearchRequest search)
        {
            var podaci = _context.PretragaIspit.Include(x => x.VrstaProizvoda).Include(x => x.Kupac).AsQueryable();
            if (search?.KupacId != null)
            {
                podaci = podaci.Where(i => i.KupacId == search.KupacId);
            }
            var lista = podaci.ToList();
            var lista2 = _mapper.Map<IList<Model.PretragaIspit>>(lista);
            foreach (var item in lista2)
            {
                item.ProsjecniPromet = _context.PretragaIspit.Where(x => x.KupacId == search.KupacId).Average(x => (decimal?)x.IznosPrometa) ?? 0;
            }
            return lista2;
        }

        public Model.PretragaIspit Insert(PretragaIspiInsertRequest request)
        {
            var objekat = _mapper.Map<Database.PretragaIspit>(request);
            _context.Add(objekat);
            _context.SaveChanges();
            return _mapper.Map<Model.PretragaIspit>(objekat);
        }
    }
}
