using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.DAL
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string Nombre  { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string PrimerApellido { get; set; }

        [Required]
        [MaxLength(100)]
        public string SegundoApellido { get; set; }
        
        [Required]
        [DefaultValue(1)]
        public int Estado { get; set; }
    }
}
