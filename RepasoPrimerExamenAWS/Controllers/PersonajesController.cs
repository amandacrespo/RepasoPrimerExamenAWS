using Microsoft.AspNetCore.Mvc;
using RepasoPrimerExamenAWS.Models;
using RepasoPrimerExamenAWS.Repositories;

namespace RepasoPrimerExamenAWS.Controllers
{
    public class PersonajesController : Controller
    {
        private RepositoryPersonajes repo;

        public PersonajesController(RepositoryPersonajes repo) {
            this.repo = repo;
        }

        public async Task<IActionResult> Index() {
            var personajes = await this.repo.GetPersonajesAsync();
            return View(personajes);
        }

        public async Task<IActionResult> Details(int id) {
            var personaje = await this.repo.FindPersonajeAsync(id);
            return View(personaje);
        }

        public async Task<IActionResult> Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Personaje personaje) {
            await this.repo.CreatePersonajeAsync(personaje.Nombre, personaje.Imagen);
            return RedirectToAction("Index");
        }
    }
}
