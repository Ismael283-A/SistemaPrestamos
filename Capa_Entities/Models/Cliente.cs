using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Capa_Entities.Models
{
    public class Cliente
    {
        [Key]
        public string Cedula { get; set; }  // Ced_Cli

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public string Celular { get; set; }

        // Relaciones
        public ICollection<Prestamo>? Prestamos { get; set; }
    }
}
