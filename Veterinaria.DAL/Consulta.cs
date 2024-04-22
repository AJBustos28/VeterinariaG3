using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        

}
}
