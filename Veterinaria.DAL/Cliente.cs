using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.DAL
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Correo { get; set; }

        public ICollection<Mascota> Mascotas { get; set;} = new List<Mascota>();

        public ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();
    }
}