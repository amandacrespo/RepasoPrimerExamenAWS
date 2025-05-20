using Microsoft.EntityFrameworkCore;
using RepasoPrimerExamenAWS.Data;
using RepasoPrimerExamenAWS.Models;
using System.Runtime.CompilerServices;

namespace RepasoPrimerExamenAWS.Repositories
{
    public class RepositoryPersonajes
    {
        private PersonajesContext context;

        public RepositoryPersonajes(PersonajesContext context) {
            this.context = context;
        }

        public async Task<List<Personaje>> GetPersonajesAsync() {
            return await this.context.Personajes.ToListAsync();
        }

        public async Task<Personaje> FindPersonajeAsync(int id) {
            return await this.context.Personajes.FirstOrDefaultAsync(p => p.IdPersonajes == id);
        }

        public async Task<int> GetNextId() {
            var maxId = await this.context.Personajes.MaxAsync(p => (int?)p.IdPersonajes);
            return maxId.HasValue ? maxId.Value + 1 : 1;
        }

        public async Task CreatePersonajeAsync(string personaje, string imagen) {
            var newPersonaje = new Personaje() {
                IdPersonajes = await GetNextId(),
                Nombre = personaje,
                Imagen = imagen
            };
            this.context.Personajes.Add(newPersonaje);
            await this.context.SaveChangesAsync();
        }
    }
}
