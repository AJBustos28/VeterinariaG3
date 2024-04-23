using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.DAL
{
    [Table("Mascotas")]
    public class Mascota
    {
        [Key]
        [Required]
        public int IdMascotas { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Especie { get; set; }
        [Required]
        public string Raza { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public string Dueño { get; set; }
        [Required]
        public string Padecimiento { get; set; }
        [Required]
        public string ImagenMascota { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }

    }
}
