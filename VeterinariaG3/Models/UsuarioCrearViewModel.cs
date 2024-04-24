using System;
using System.ComponentModel.DataAnnotations;

namespace VeterinariaG3.ViewModels
{
    public class UsuarioCrearViewModel
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress(ErrorMessage = "El Email no es válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El segundo apellido es requerido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public int Estado { get; set; }

        [Required(ErrorMessage = "La fecha de última conexión es requerida")]
        [Display(Name = "Última conexión")]
        public DateTime UltimaConexion { get; set; }

        [Display(Name = "Imagen")]
        public string Imagen { get; set; }
    }
}
