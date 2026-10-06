using app_curso_claude.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_curso_claude.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            // After a successful POST + redirect, the success notification arrives via TempData.
            // Reading it marks it for deletion; copying it to ViewData keeps it available to the layout.
            if (TempData["NotificationMessage"] is string message)
            {
                ViewData["NotificationMessage"] = message;
                ViewData["NotificationType"] = TempData["NotificationType"] as string ?? "success";
            }
            else
            {
                ViewData["NotificationMessage"] = "Completa el formulario y te responderemos lo antes posible.";
                ViewData["NotificationType"] = "info";
            }

            return View(new ContactoViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(ContactoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["NotificationMessage"] = "Revisa los campos marcados antes de enviar el formulario.";
                ViewData["NotificationType"] = "warning";
                return View(model);
            }

            // No database: the message is not persisted.
            TempData["NotificationMessage"] = $"Gracias, {model.Nombre}. Hemos recibido tu mensaje.";
            TempData["NotificationType"] = "success";
            return RedirectToAction(nameof(Index));
        }
    }
}
