using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

namespace OData.Controllers
{
    [Route("api/curso")]
    public class CursoController : ODataController
    {

        private readonly Context _context;

        public CursoController(Context context)
        {
            _context = context;
        }


        [EnableQuery]
        public IQueryable<Curso> Get() => _context.Curso.AsQueryable();
    }
}