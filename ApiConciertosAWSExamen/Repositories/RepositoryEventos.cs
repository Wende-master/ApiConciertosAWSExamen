using ApiConciertosAWSExamen.Data;
using ApiConciertosAWSExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConciertosAWSExamen.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;
        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos
                .ToListAsync();
        }

        public async Task<Evento> FindEventoAsync(int id)
        {
            return await this.context.Eventos
                .FirstOrDefaultAsync(z => z.IdEvento == id);
        }

        public async Task<List<Evento>> FindEventosByCategoriaAsync(int idcategoria)
        {
            return await this.context.Eventos
                .Where(x => x.IdCategoria == idcategoria).ToListAsync();
        }

        public async Task<List<CategoriaEvento>> GetCategoriasAsync()
        {
            return await this.context.Categorias
                .ToListAsync();
        }
    }
}
