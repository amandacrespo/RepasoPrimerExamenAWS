using Microsoft.EntityFrameworkCore;
using RepasoPrimerExamenAWS.Models;

namespace RepasoPrimerExamenAWS.Data
{
    public class PersonajesContext:DbContext
    {
        public PersonajesContext(DbContextOptions<PersonajesContext> options) 
            : base(options) 
            {}

        public DbSet<Personaje> Personajes { get; set; }
    }
}
