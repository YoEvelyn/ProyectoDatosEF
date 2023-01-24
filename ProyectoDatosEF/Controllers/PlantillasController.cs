using Microsoft.AspNetCore.Mvc;
using ProyectoDatosEF.Models;
using ProyectoDatosEF.Repositories;

namespace ProyectoDatosEF.Controllers
{
    public class PlantillasController : Controller
    {
        private RepositoryPlantilla repo;

        public PlantillasController(RepositoryPlantilla repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Plantilla> plantillas = this.repo.GetPlantillas();
            return View(plantillas);
        }

        public IActionResult PlantillasHospital(int idhospital)
        {
            List<Plantilla> plantillas = this.repo.GetPlantillasHospital(idhospital);
            return View(plantillas);
        }

        public IActionResult Detalles(int id)
        {
            Plantilla plantilla = this.repo.FindPlantilla(id);
            return View(plantilla);
        }

        public IActionResult BuscarPlantillaFuncion()
        {
            List<Plantilla> plantillas = this.repo.GetPlantillas();
            return View(plantillas);
        }

        [HttpPost]
        public IActionResult BuscarPlantillaFuncion(string funcion)
        {
            List<Plantilla> plantillas = this.repo.GetPlantillaFuncion(funcion);
            return View(plantillas);
        }
    }
}
