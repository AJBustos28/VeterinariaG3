using System.ComponentModel.DataAnnotations;

namespace VeterinariaG3.Models
{
    public class RolViewModel
    {
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre { get; set; }
    }
}