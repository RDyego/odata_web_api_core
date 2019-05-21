using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

namespace OData.Controllers
{
    [Route("api/cadeiras")]
    public class CadeiraController : ODataController
    {
        private readonly Context _context;

        public CadeiraController(Context context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Cadeiras> Get() => _context.Cadeiras.AsQueryable();

        //public IQueryable<Cadeiras> Get()
        //{
        //    try
        //    {
        //        var teste = _context.Cadeiras.Include(x=>x.Matricula).AsQueryable();
        //        return teste;

        //    }
        //    catch (System.Exception e)
        //    {

        //        throw e;
        //    }

        //}
    }
}