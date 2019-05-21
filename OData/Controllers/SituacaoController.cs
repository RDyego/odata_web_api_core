using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.Contexto;
using OData.Modelo;
using System.Linq;

[Route("api/situacao")]
public class SituacaoController : ODataController
{
    private readonly Context _context;

    public SituacaoController(Context context)
    {
        _context = context;
    }

    [EnableQuery]
    public IQueryable<Situacao> Get() => _context.Situacao.AsQueryable();

}