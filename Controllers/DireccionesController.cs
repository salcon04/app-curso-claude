using app_curso_claude.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_curso_claude.Controllers
{
    public class DireccionesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NotificationMessage"] = "Consulta nuestras sedes y elige la más cercana a ti.";
            ViewData["NotificationType"] = "info";

            var direcciones = new List<DireccionViewModel>
            {
                new DireccionViewModel
                {
                    Nombre = "Sede Central",
                    Calle = "Av. Principal 123",
                    Ciudad = "Madrid",
                    Telefono = "+34 910 000 001",
                    Horario = "Lunes a viernes, 9:00 - 18:00"
                },
                new DireccionViewModel
                {
                    Nombre = "Sede Norte",
                    Calle = "Calle de la Industria 45",
                    Ciudad = "Barcelona",
                    Telefono = "+34 930 000 002",
                    Horario = "Lunes a viernes, 8:30 - 17:30"
                },
                new DireccionViewModel
                {
                    Nombre = "Sede Sur",
                    Calle = "Paseo del Puerto 7",
                    Ciudad = "Sevilla",
                    Telefono = "+34 950 000 003",
                    Horario = "Lunes a sábado, 10:00 - 14:00"
                }
            };

            return View(direcciones);
        }
    }
}
