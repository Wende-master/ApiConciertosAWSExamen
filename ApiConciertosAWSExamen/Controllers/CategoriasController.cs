using ApiConciertosAWSExamen.Models;
using ApiConciertosAWSExamen.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiConciertosAWSExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private RepositoryEventos repo;
        public CategoriasController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoriaEvento>>> Categorias()
        {
            return await this.repo.GetCategoriasAsync();
        }
    }
}
