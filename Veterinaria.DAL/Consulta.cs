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

        public string ConsultaCreacionId { get; set; }

        public ApplicationUser? ConsultaCreacion { get; set; }

       

    }
}
