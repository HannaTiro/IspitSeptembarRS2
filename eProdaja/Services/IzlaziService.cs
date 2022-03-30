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
    public class IzlaziService:IIzlaziService
    {
        public eProdajaContext  _context { get; set; }
        protected readonly IMapper _mapper;
        public IzlaziService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Izlazi> GetAll(IzlaziSearchRequest search)
        {
            var podaci = _context.Izlazis.Include(x=>x.Korisnik).Include(x=>x.Narudzba.Kupac).AsQueryable();

            if(search?.VrstaPorizvodaId!=null)
            {
                podaci = podaci.Where(x => x.IzlazStavkes.Count(x => x.Proizvod.VrstaId == search.VrstaPorizvodaId) > 0);
            }
            if(search?.DatumOd!=null)
            {
                podaci = podaci.Where(x => x.Datum >= search.DatumOd);
            }
            if(search?.DatumDo!=null)
            {
                podaci = podaci.Where(x => x.Datum <= search.DatumDo);
            }
            if(search?.MinIznosPrometa!=null)
            {
                podaci = podaci.Where(x => x.IznosSaPdv >= search.MinIznosPrometa);
            }
            var lista = podaci.ToList();
            return _mapper.Map<IList<Model.Izlazi>>(lista);
        }
    }
}
