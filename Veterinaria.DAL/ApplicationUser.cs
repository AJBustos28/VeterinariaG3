using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.DAL
{
    [Table("AspNetUse")]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string PrimerApellido { get; set; }

        [Required]
        [MaxLength(100)]
        public string SegundoApellido { get; set; }

        [Required]
        public int Estado { get; set; }

        [Required]
        public DateTime UltimaConexion { get; set; }

        public string Imagen { get; set; }

        // Relación con el rol
        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
