using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

namespace OData.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : ODataController
    {
        private readonly Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Usuario> Get() => _context.Usuario.AsQueryable();
    }
}