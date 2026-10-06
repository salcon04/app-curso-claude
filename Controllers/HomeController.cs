using app_curso_claude.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app_curso_claude.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NotificationMessage"] = "Bienvenido. Usa el menú para consultar nuestros datos de contacto y direcciones.";
            ViewData["NotificationType"] = "info";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["NotificationMessage"] = "Revisa cómo tratamos tu información personal.";
            ViewData["NotificationType"] = "info";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
