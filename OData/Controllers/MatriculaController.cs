using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

namespace OData.Controllers
{
    [Route("api/matricula")]
    public class MatriculaController : ODataController
    {
        private readonly Context _context;

        public MatriculaController(Context context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Matricula> Get() => _context.Matricula.AsQueryable();
    }
}