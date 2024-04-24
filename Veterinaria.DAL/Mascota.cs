using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string CreacionMascotaId { get; set; }

        public ApplicationUser? CreacionMascota { get; set; }

        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
