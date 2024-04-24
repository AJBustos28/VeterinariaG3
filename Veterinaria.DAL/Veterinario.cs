using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.DAL
{
    [Table("Veterinario")]
    public class Veterinario
    {
        [Key]
        [Required]
        public int IdMascota { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especialidad { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Genero { get; set; }

    }
}
