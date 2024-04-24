using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.DAL
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        [Required]
        public int IdConsulta { get; set; }

        [Required]
        public DateTime DateTimeValue { get; set; }

        [Required]
        public string Motivo { get; set; }

        [Required]
        public string Diagnostico { get; set; }

        [Required]
        public string Tratamiento { get; set; }

        [Required]
        public string Medicamentos { get; set; }

        // Relación con Veterinario
        [ForeignKey("Veterinario")]
        public int VeterinarioId { get; set; }
        public virtual Veterinario Veterinario { get; set; }

        // Relación con Cliente
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}