using System.ComponentModel.DataAnnotations;

namespace app_curso_claude.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los {1} caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Introduce un correo electrónico válido.")]
        [StringLength(256, ErrorMessage = "El correo electrónico no puede superar los {1} caracteres.")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El mensaje es obligatorio.")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "El mensaje debe tener entre {2} y {1} caracteres.")]
        [Display(Name = "Mensaje")]
        public string Mensaje { get; set; } = string.Empty;
    }
}
