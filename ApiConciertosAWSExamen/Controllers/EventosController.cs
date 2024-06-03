using ApiConciertosAWSExamen.Models;
using ApiConciertosAWSExamen.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiConciertosAWSExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;
        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Evento>>> Conciertos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<Evento>>> FindConciertos(int id)
        {
            return await this.repo.FindEventosByCategoriaAsync(id);
        }


    }
}
