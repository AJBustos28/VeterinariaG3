using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.DAL
{
    [Table("Veterinario")]
    public class Veterinario
    {
        [Key]
        [Required]
        public int IdVeterinario { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especialidad { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Correo { get; set; }

        public ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();
    }
}
