using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

namespace OData.Controllers
{
    [Route("api/aluno")]
    public class AlunoController : ODataController
    {
        private readonly Context _context;

        public AlunoController(Context context)
        {
            _context = context;
        }

        [EnableQuery]
        public IQueryable<Aluno> Get() => _context.Aluno.AsQueryable();
    }
}